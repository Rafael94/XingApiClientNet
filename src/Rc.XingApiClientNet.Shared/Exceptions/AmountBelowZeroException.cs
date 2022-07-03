using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class AmountBelowZeroException : XingException
{
    public AmountBelowZeroException() : base("You provided an amount of tickets that is less than zero.")
    {

    }
}
