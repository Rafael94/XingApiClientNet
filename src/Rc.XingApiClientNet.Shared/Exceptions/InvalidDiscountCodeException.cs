using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidDiscountCodeException : XingException
{
    public InvalidDiscountCodeException() : base("You tried to apply a discount code, that is invalid.")
    {

    }
}
