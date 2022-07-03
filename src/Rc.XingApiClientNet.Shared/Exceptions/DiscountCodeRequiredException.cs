using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DiscountCodeRequiredException : XingException
{
    public DiscountCodeRequiredException() : base("You tried to buy a ticket form a category, that is hidden by a discount code.")
    {

    }
}
