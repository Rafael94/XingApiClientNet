using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class ExceededMaxSellException : XingException
{
    public ExceededMaxSellException() : base("You provided an amount of tickets that exceeded the maximum for this category.")
    {

    }
}
