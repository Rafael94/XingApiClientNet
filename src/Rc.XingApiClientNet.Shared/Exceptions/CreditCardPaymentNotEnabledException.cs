using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class CreditCardPaymentNotEnabledException : XingException
{
    public CreditCardPaymentNotEnabledException() : base("You tried to charge a payment with creditcard an this feature ist not enabled for your event.")
    {

    }
}
