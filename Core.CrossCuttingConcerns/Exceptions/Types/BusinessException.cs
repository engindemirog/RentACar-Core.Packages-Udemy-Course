using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Types;

public class BusinessException:Exception
{
    public BusinessException()
    {
        
    }

    public BusinessException(string? message):base(message) { }

    public BusinessException(string? message, Exception? innerException) : base(message, innerException) { }
}
