using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class CannotUpdateNonDraftPaymentException : XingException
{
    public CannotUpdateNonDraftPaymentException() : base("You tried to update a payment that is not in draft mode.")
    {

    }
}
