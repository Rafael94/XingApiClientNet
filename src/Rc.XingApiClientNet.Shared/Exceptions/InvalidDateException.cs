using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidDateException : XingException
{
    public InvalidDateException() : base ("The value you provided for a date type user field is not valid.")
    {

    }
}
