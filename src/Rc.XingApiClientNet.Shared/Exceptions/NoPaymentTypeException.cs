using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoPaymentTypeException : XingException
{
    public NoPaymentTypeException() :base("The event has no payment types (credit-card, invoice, etc.) defined yet.")
    {

    }
}
