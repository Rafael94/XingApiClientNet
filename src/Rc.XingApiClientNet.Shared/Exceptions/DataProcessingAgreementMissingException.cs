using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DataProcessingAgreementMissingException : XingException
{
    public DataProcessingAgreementMissingException() : base("For some calls you need to sign a \"data processing agreement\". Please contact our support or your account manager if you didn't sign this agreement yet.")
    {

    }
}
