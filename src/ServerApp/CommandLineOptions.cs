using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal class CommandLineOptions
  {
    // Command line parse results
    public const int ParseOK = 0;
    public const int ParseFailed = 1;

    [Option(longName: "autoAccept", Required = false, HelpText = "Auto-accept any client certificate")]
    public bool AutoAccept { get; set; }

    [Option(longName: "certificate", Required = false, HelpText = "Server certificate filename")]
    public string? CertificateFilename { get; set; }

    [Option(longName: "password", Required = false, HelpText = "Server certificate password")]
    public string? CertificatePassword { get; set; }

    [Option(longName: "logFile", Required = false, HelpText = "Name of file for log output")]
    public string? LogFile { get; set; }
  }
  // Example:  ServerApp --autoAccept --certificate ./Certificates/Server.pfx --password SecretValueFromEnvironmentVariable
}
