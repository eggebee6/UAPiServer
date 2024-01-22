using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal enum ExitCode
  {
    // General exit codes
    Unknown,
    OK,
    Error,

    // Specific exit codes
    CommandLineParseFailed,
    CertificateError,
    ServerError,
  }

  internal static class ExitClassUtility
  {
    private static readonly Array ExitCodes = Enum.GetValues(typeof(ExitCode));
    private static readonly Lazy<Dictionary<ExitCode, int>> ExitCodeValues = new (() =>
    {
      // Add pre-defined error code values
      var ret = new Dictionary<ExitCode, int>()
      {
        { ExitCode.Unknown, -1 },
        { ExitCode.OK, 0 },
        { ExitCode.Error, 1 }
      };

      // Return initialized map
      return ret;
    });
      
    public static int Value(this ExitCode code)
    {
      var valueMap = ExitCodeValues.Value;
      if (valueMap.TryGetValue(code, out int val))
      {
        return val;
      }

      return valueMap[ExitCode.Unknown];
    }
  }
}
