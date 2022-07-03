using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DirectPaymentWithoutNameException : XingException
{
    public DirectPaymentWithoutNameException() : base("Thrown if you try to activate a \"PAYMENT_TYPE_DIRECT\" type without having provided the name for the payment type.")
    {

    }
}
