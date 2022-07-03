using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class MaxSellLowerThanMinSellException : XingException
{
    public MaxSellLowerThanMinSellException() : base("You provided a number for max sell, that is lower than the min sell.")
    {

    }
}
