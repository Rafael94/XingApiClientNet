using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class ErrorOnSendingException : XingException
{
    public ErrorOnSendingException() : base("An error occurred while sending the email.")
    {

    }
}
