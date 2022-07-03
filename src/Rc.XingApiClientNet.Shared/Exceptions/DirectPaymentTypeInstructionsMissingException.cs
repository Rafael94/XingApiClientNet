using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DirectPaymentTypeInstructionsMissingException : XingException
{
    public DirectPaymentTypeInstructionsMissingException() : base("For custom payment types we need to provide the ticket buyers with information on how to pay. For this you can either provide a URL with further instructions (parameter paymentPage) or textual instructions like \"send a check to...\" (parameter paymentInstructions)")
    {

    }
}
