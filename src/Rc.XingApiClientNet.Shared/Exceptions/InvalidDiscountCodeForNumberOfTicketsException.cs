using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidDiscountCodeForNumberOfTicketsException : XingException
{
    public InvalidDiscountCodeForNumberOfTicketsException() : base("The used discount codes is not valid for that amount of tickets (e.g. code only valid once, but two tickets are selected).")
    {

    }
}
