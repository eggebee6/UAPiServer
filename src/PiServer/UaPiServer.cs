﻿/* ========================================================================
* Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
*
* OPC Foundation MIT License 1.00
* 
* Permission is hereby granted, free of charge, to any person
* obtaining a copy of this software and associated documentation
* files (the "Software"), to deal in the Software without
* restriction, including without limitation the rights to use,
* copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the
* Software is furnished to do so, subject to the following
* conditions:
* 
* The above copyright notice and this permission notice shall be
* included in all copies or substantial portions of the Software.
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
* EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
* OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
* NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
* HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
* WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
* FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
* OTHER DEALINGS IN THE SOFTWARE.
*
* The complete license agreement can be found here:
* http://opcfoundation.org/License/MIT/1.00/
* ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Opc.Ua;
using Opc.Ua.Server;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;
using Opc.Ua.Configuration;
using PiServer.SenseHat;

namespace PiServer
{
  /// <summary>
  /// Implements a basic Quickstart Server.
  /// </summary>
  /// <remarks>
  /// Each server instance must have one instance of a StandardServer object which is
  /// responsible for reading the configuration file, creating the endpoints and dispatching
  /// incoming requests to the appropriate handler.
  /// 
  /// This sub-class specifies non-configurable metadata such as Product Name and initializes
  /// the EmptyNodeManager which provides access to the data exposed by the Server.
  /// </remarks>
  public partial class UaPiServer : StandardServer
  {
    public UaPiServer(Action<PiServerOptions>? optionsConfig = null)
    {
      serverOptions = new PiServerOptions();
      optionsConfig?.Invoke(serverOptions);

      logger = serverOptions.LoggerFactory?.CreateLogger<UaPiServer>() ?? new NullLogger<UaPiServer>();

      CertificateValidator validator = new CertificateValidator()
      {
        AutoAcceptUntrustedCertificates = serverOptions.AutoAccept
      };
      certificateValidator = validator.GetChannelValidator();
    }

    #region Overridden Methods
    /// <summary>
    /// Creates the node managers for the server.
    /// </summary>
    /// <remarks>
    /// This method allows the sub-class create any additional node managers which it uses. The SDK
    /// always creates a CoreNodeManager which handles the built-in nodes defined by the specification.
    /// Any additional NodeManagers are expected to handle application specific nodes.
    /// </remarks>
    protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
    {
      List<INodeManager> nodeManagers = new List<INodeManager>();

      logger.LogInformation("Creating node managers");

      // Add Sense HAT node manager
      nodeManagers.Add(new SenseHatNodeManager(
        server,
        configuration,
        serverOptions.SenseHat));

      return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
    }

    /// <summary>
    /// Loads the non-configurable properties for the application.
    /// </summary>
    /// <remarks>
    /// These properties are exposed by the server but cannot be changed by administrators.
    /// </remarks>
    protected override ServerProperties LoadServerProperties()
    {
      ServerProperties properties = new ServerProperties()
      {
        ManufacturerName = "Milwaukee Cybertechnology",
        ProductName = "OPC UA Pi Server",
        ProductUri = "http://mkecybertech.com/UA/PiServer",
        SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
        BuildNumber = Utils.GetAssemblyBuildNumber(),
        BuildDate = Utils.GetAssemblyTimestamp()
      };

      // TODO: Certificates

      return properties;
    }

    /// <summary>
    /// Creates the resource manager for the server.
    /// </summary>
    protected override ResourceManager CreateResourceManager(IServerInternal server, ApplicationConfiguration configuration)
    {
      ResourceManager resourceManager = new ResourceManager(server, configuration);

      System.Reflection.FieldInfo[] fields =
        typeof(StatusCodes).GetFields(
          System.Reflection.BindingFlags.Public |
          System.Reflection.BindingFlags.Static);

      foreach (System.Reflection.FieldInfo field in fields)
      {
        uint? id = field.GetValue(typeof(StatusCodes)) as uint?;
        if (id != null)
        {
          resourceManager.Add(id.Value, "en-US", field.Name);
        }
      }

      return resourceManager;
    }

    /// <summary>
    /// Initializes the server before it starts up.
    /// </summary>
    /// <remarks>
    /// This method is called before any startup processing occurs. The sub-class may update the 
    /// configuration object or do any other application specific startup tasks.
    /// </remarks>
    protected override void OnServerStarting(ApplicationConfiguration configuration)
    {
      logger.LogInformation("Server starting");

      base.OnServerStarting(configuration);

      // it is up to the application to decide how to validate user identity tokens.
      // this function creates validator for X509 identity tokens.
      CreateUserIdentityValidators(configuration);
    }

    /// <summary>
    /// Called after the server has been started.
    /// </summary>
    protected override void OnServerStarted(IServerInternal server)
    {
      base.OnServerStarted(server);

      // request notifications when the user identity is changed. all valid users are accepted by default.
      server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);

      // TODO: Set up nodes and node managers
    }

    /// <summary>
    /// Initializes the address space after the NodeManagers have started.
    /// </summary>
    /// <remarks>
    /// This method can be used to create any initialization that requires access to node managers.
    /// </remarks>
    protected override void OnNodeManagerStarted(IServerInternal server)
    {
      logger.LogInformation("NodeManagers started");

      // allow base class processing to happen first.
      base.OnNodeManagerStarted(server);
    }

    protected override void OnServerStopping()
    {
      logger.LogWarning("Server stopping");

      base.OnServerStopping();

      // TODO: Clean up nodes and node managers
    }

    #endregion
    #region User Validation Functions
    /// <summary>
    /// Creates the objects used to validate the user identity tokens supported by the server.
    /// </summary>
    private void CreateUserIdentityValidators(ApplicationConfiguration configuration)
    {
      for (int ii = 0; ii < configuration.ServerConfiguration.UserTokenPolicies.Count; ii++)
      {
        UserTokenPolicy policy = configuration.ServerConfiguration.UserTokenPolicies[ii];

        // create a validator for a certificate token policy.
        if (policy.TokenType == UserTokenType.Certificate)
        {
          // check if user certificate trust lists are specified in configuration.
          if (configuration.SecurityConfiguration.TrustedUserCertificates != null &&
              configuration.SecurityConfiguration.UserIssuerCertificates != null)
          {
            CertificateValidator validator = new CertificateValidator();
            validator.Update(configuration.SecurityConfiguration).Wait();
            validator.Update(
              configuration.SecurityConfiguration.UserIssuerCertificates,
              configuration.SecurityConfiguration.TrustedUserCertificates,
              configuration.SecurityConfiguration.RejectedCertificateStore);

            // set custom validator for user certificates.
            certificateValidator = validator.GetChannelValidator();
          }
        }
      }
    }

    /// <summary>
    /// Called when a client tries to change its user identity.
    /// </summary>
    private void SessionManager_ImpersonateUser(Session session, ImpersonateEventArgs args)
    {
      // check for x509 user token.
      if (args.NewIdentity is X509IdentityToken x509Token)
      {
        VerifyUserTokenCertificate(x509Token.Certificate);
        args.Identity = new UserIdentity(x509Token);
        logger.LogInformation("X509 Token Accepted: {name}", args.Identity.DisplayName);
        return;
      }
    }

    /// <summary>
    /// Verifies that a certificate user token is trusted.
    /// </summary>
    private void VerifyUserTokenCertificate(X509Certificate2 certificate)
    {
      try
      {
        certificateValidator.Validate(certificate);
      }
      catch (ServiceResultException e)
      {
        string message = e.StatusCode switch
        {
          StatusCodes.BadCertificatePolicyCheckFailed => $"'{certificate.Subject}' does not meet security policy requirements",
          StatusCodes.BadCertificateUntrusted => $"'{certificate.Subject}' is not trusted",
          StatusCodes.BadCertificateUseNotAllowed => $"'{certificate.Subject}' use is not allowed",
          StatusCodes.BadCertificateInvalid => $"'{certificate.Subject}' is invalid",
          StatusCodes.BadIdentityTokenRejected => $"'{certificate.Subject}' token is rejected",
          _ => $"'{certificate.Subject}' could not be validated",
        };

        logger.LogError(e, message);
        throw;
      }
    }
    #endregion

    #region Utility
    public async Task StartServer(
      string configFile,
      string? certificatePassword)
    {
      if (string.IsNullOrWhiteSpace(configFile))
      {
        throw new ArgumentException("Invalid config file", nameof(configFile));
      }

      if (applicationInstance != null)
      {
        throw new InvalidOperationException("Server application instance already exists");
      }

      applicationInstance = new ApplicationInstance();
      applicationInstance.ApplicationType = ApplicationType.Server;
      applicationInstance.ConfigSectionName = "PiServer";

      try
      {
        ApplicationConfiguration config = await applicationInstance.LoadApplicationConfiguration(configFile, false);

        config.SecurityConfiguration.ApplicationCertificate = new CertificateIdentifier(serverOptions.Certificate);
        config.SecurityConfiguration.CertificatePasswordProvider = new CertificatePasswordProvider(certificatePassword);

        /*
         * TODO: The call to app.CheckApplicationInstanceCertificate() seems to mess up the certificate
         * After the call, the certificate issuer is overwritten by a copy of the certificate subject
         */
        bool haveAppCertificate = await applicationInstance.CheckApplicationInstanceCertificate(false, 0);
        if (!haveAppCertificate)
        {
          throw new Exception("Application instance certificate invalid!");
        }

        if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
        {
          config.CertificateValidator.CertificateValidation += CertificateValidation;
        }

        await applicationInstance.Start(this);

        CurrentInstance.SessionManager.SessionActivated += EventStatus;
        CurrentInstance.SessionManager.SessionClosing += EventStatus;
        CurrentInstance.SessionManager.SessionCreated += EventStatus;
      }
      catch
      {
        throw;
      }
    }

    public Task StopServer()
    {
      applicationInstance?.Stop();
      applicationInstance = null;

      return Task.CompletedTask;
    }

    private string GetSessionStatusString(Session session, string reason, bool lastContact = false)
    {
      lock (session.DiagnosticsLock)
      {
        string item = string.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);

        if (lastContact)
        {
          item += string.Format("Last Event: {0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
        }
        else
        {
          if (session.Identity != null)
          {
            item += string.Format(":{0,20}", session.Identity.DisplayName);
          }
          item += string.Format(":{0}", session.Id);
        }

        return item;
      }
    }

    private void EventStatus(Session session, SessionEventReason reason)
    {
      string str = GetSessionStatusString(session, reason.ToString());
      logger.LogInformation(str);
    }

    private void CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
    {
      if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
      {
        e.Accept = serverOptions.AutoAccept;
        if (serverOptions.AutoAccept)
        {
          logger.LogInformation("Accepted certificate {subject}", e.Certificate.Subject);
        }
        else
        {
          logger.LogWarning("Rejected certificate {subject}", e.Certificate.Subject);
        }
      }
    }
    #endregion

    #region Fields
    private readonly PiServerOptions serverOptions;
    private readonly ILogger<UaPiServer> logger;

    private ICertificateValidator certificateValidator;
    private ApplicationInstance? applicationInstance = null;
    #endregion


    public class PiServerOptions
    {
      public ILoggerFactory? LoggerFactory = null;

      public X509Certificate2? Certificate = null;
      public bool AutoAccept = false;

      public ISenseHat SenseHat = null;
    }
  }
}
