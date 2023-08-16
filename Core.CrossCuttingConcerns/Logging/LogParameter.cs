using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging;

public class LogParameter
{
    public string Name { get; set; }
    public object Value { get; set; }
    public string Type { get; set; }

    public LogParameter()
    {
        Name = string.Empty;
        Value = string.Empty;
        Type = string.Empty;
    }

    public LogParameter(string name, object value, string type)
    {
        Name=name;
        Value=value;
        Type=type;
    }
}
