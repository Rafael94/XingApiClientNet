using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidMaxSellException : XingException
{
    public InvalidMaxSellException() : base("You provided a number for max sell, that is below 1.")
    {

    }
}
