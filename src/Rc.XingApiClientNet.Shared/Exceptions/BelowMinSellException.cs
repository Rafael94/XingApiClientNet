using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class BelowMinSellException : XingException
{
    public BelowMinSellException() : base("ou provided an amount of tickets that is less than the minimum for this category.")
    {

    }
}
