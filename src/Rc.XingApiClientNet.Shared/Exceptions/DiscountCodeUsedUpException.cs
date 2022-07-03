using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DiscountCodeUsedUpException : XingException
{
    public DiscountCodeUsedUpException() : base("You tried to apply a discount code, that is used up.")
    {

    }
}
