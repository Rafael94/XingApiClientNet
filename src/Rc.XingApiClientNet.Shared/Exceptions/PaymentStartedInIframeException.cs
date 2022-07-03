using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class PaymentStartedInIframeException : XingException
{
    public PaymentStartedInIframeException() : base("You tried to finish a payment via API that was started (or at one point opened) in an IFrame of the ticketshop. This is sadly not supported because there can be complications with data protection and legal issues in regards to who/when excepted terms and conditions.")
    {

    }
}
