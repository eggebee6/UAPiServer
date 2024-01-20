using AutoMapper;
using CommandLine;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PiServer;

namespace ServerApp
{
  internal class Program
  {
    private static ILogger<Program> logger = new NullLogger<Program>();
    private static ServerAppOptions programOptions = new ServerAppOptions();

    static async Task<int> Main(string[] args)
    {
      // Parse command line arguments
      int parseResult = ParseCommandLineArguments(args);
      if (parseResult != CommandLineOptions.ParseOK)
      {
        return ExitCode.CommandLineParseFailed.Value();
      }

      // Create logger factory and program logger
      var loggerFactory = CreateLoggerFactory();
      logger = loggerFactory.CreateLogger<Program>();

      // Get server certificate (or use default certificate)
      X509Certificate2? certificate = null;
      if (programOptions.CertificateFilename != null)
      {
        try
        {
          certificate = GetServerCertificate(
            programOptions.CertificateFilename,
            programOptions.CertificatePassword ?? string.Empty);
        }
        catch (Exception ex)
        {
          logger.LogError(ex, "Failed to get server certificate");
          return ExitCode.CertificateError.Value();
        }
      }

      if (certificate != null)
      {
        logger.LogInformation("Using certificate {name}", certificate.SubjectName.Name);
      }
      else
      {
        logger.LogWarning("No certificate specified");
      }

      // Warn if auto-accept is enabled
      if (programOptions.AutoAccept)
      {
        logger.LogWarning("Auto-accept client certificates is ON");
      }

      // TODO: Initialize Sense HAT or create Sense HAT simulation
      //SimulatedSenseHat sim = new SimulatedSenseHat();

      // Create server
      UaPiServer piServer = new UaPiServer(opts =>
      {
        opts.LoggerFactory = loggerFactory;
        opts.Certificate = certificate;
        opts.AutoAccept = programOptions.AutoAccept;
      });
      
      ExitCode exitCode = ExitCode.Error;
      try
      {
        logger.LogInformation("Starting server");

        // Start server
        await piServer.StartServer(
          "Resources/Configuration/PiServer.Config.xml",
          programOptions.CertificatePassword);

        // Send quit signal when CTRL+C is received
        ManualResetEvent quitEvent = new ManualResetEvent(false);
        Console.CancelKeyPress += (sender, eArgs) =>
        {
          quitEvent.Set();
          eArgs.Cancel = true;
        };

        // Run until stop event occurs
        logger.LogInformation("Running server, CTRL+C to stop");
        quitEvent.WaitOne(Timeout.Infinite);

        exitCode = ExitCode.OK;
      }
      catch (Exception ex)
      {
        // Log server exception
        logger.LogError(ex, "Unhandled server exception");

        exitCode = ExitCode.ServerError;
      }
      finally
      {
        logger.LogWarning("Stopping server");
        
        // Stop server
        await piServer.StopServer();
      }

      // Done
      int exitValue = exitCode.Value();
      logger.LogInformation($"Exiting, exit code {exitValue}");
      return exitValue;
    }

    /// <summary>
    /// Parse the command line arguments and store the results
    /// </summary>
    /// <param name="args">Command line arguments</param>
    /// <returns>Status code of parse result</returns>
    private static int ParseCommandLineArguments(string[] args)
    {
      var optsMapper = GetOptionsMapper();

      // Parse command line options and return result
      return Parser.Default
        .ParseArguments<CommandLineOptions>(args)
        .MapResult(
          opts =>
          {
            programOptions = optsMapper.Map<ServerAppOptions>(opts);
            return CommandLineOptions.ParseOK;
          },
          errors =>
          {
            return CommandLineOptions.ParseFailed;
          });
    }

    /// <summary>
    /// Get a mapper to convert the command line options to program options
    /// </summary>
    /// <returns>Mapper for option conversion</returns>
    private static Mapper GetOptionsMapper()
    {
      var mapperConfig = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<CommandLineOptions, ServerAppOptions>();
      });

      return new Mapper(mapperConfig);
    }

    /// <summary>
    /// Create the factory for getting loggers
    /// </summary>
    /// <returns>Logger factory</returns>
    private static LoggerFactory CreateLoggerFactory(string? logFilename = null)
    {
      var loggerConfig = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console();

      if (logFilename != null)
      {
        loggerConfig.WriteTo.File(logFilename);
      }

      LoggerFactory loggerFactory = new LoggerFactory();
      loggerFactory.AddSerilog(loggerConfig.CreateLogger());

      return loggerFactory;
    }

    /// <summary>
    /// Get the certificate for the server
    /// </summary>
    /// <returns>Server certificate, or null for no certificate</returns>
    private static X509Certificate2? GetServerCertificate(
      string certificateFilename,
      string certificatePassword)
    {
      if (string.IsNullOrWhiteSpace(certificateFilename))
      {
        throw new ArgumentException($"'{nameof(certificateFilename)}' cannot be null or whitespace.", nameof(certificateFilename));
      }

      certificatePassword ??= string.Empty;

      // Load certificate from file, or use default certificate if no filename is provided
      try
      {
        X509Certificate2 certificate = new X509Certificate2(certificateFilename, certificatePassword);
        return certificate;
      }
      catch
      {
        logger.LogError("Failed to load certificate from {filename}", certificateFilename);
        throw;
      }
    }
  }
}
