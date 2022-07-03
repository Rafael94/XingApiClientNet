using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class EmailInvalidException : XingException
{
    public EmailInvalidException() : base("You provided an invalid email address.")
    {

    }
}
