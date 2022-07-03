using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class PaymentTypeNotAllowedException : XingException
{
    public PaymentTypeNotAllowedException() : base("This type is not allowed for the event.")
    {

    }
}
