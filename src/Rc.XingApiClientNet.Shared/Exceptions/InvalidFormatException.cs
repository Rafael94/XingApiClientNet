using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidFormatException : XingExceptionWithDetail
{
    public InvalidFormatException(string error) : base(error, "The format of the property is not correct (for example: a date field).")
    {

    }
}
