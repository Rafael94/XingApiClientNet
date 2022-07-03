using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidGenderException : XingException
{
    public InvalidGenderException() : base ("DEPRECATED! The value you provided for a gender user field is not valid.")
    {

    }
}
