using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class PaymentTypeAlreadyExistsException : XingException
{
    public PaymentTypeAlreadyExistsException() : base("This type already exists. You have to update the existing one to activate it.")
    {

    }
}
