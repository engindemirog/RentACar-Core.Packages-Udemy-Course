using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Serilog.Messages;

public static class SerilogMessages
{
    public static string NullOptionsMessage => "You have sent a blank value! Something went wrong. Please try again.";
}
