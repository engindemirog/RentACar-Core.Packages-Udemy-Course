using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging;

public class LogDetail
{
    public string FullName { get; set; }
    public string MethodName { get; set; }
    public string User { get; set; }
    public List<LogParameter> Parameters { get; set; }

    public LogDetail()
    {
        FullName = string.Empty;
        MethodName = string.Empty;
        User = string.Empty;
        Parameters = new List<LogParameter>();
    }

    public LogDetail(string fullName, string methodName, string user, List<LogParameter> parameters)
    {
        fullName = fullName;
        MethodName = methodName;
        User = user;
        Parameters = parameters;
    }
}
