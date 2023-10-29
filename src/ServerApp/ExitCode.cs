using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal static class ExitCode
  {
    public static readonly int OK = 0;
    public static readonly int Error = 1;
    public static readonly int ParseFailed = 2;
    public static readonly int CertificateError = 3;
    public static readonly int ServerError = 4;
  }
}
