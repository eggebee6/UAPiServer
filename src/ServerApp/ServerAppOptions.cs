using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal class ServerAppOptions
  {
    public bool AutoAccept = false;
    public string? CertificateFilename = null;
    public string? CertificatePassword = null;
    public string? LogFile = null;
  }
}
