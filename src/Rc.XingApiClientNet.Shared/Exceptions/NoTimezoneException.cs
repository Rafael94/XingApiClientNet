using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTimezoneException : XingException
{
    public NoTimezoneException() : base("The event has no timezone set.")
    {

    }
}
