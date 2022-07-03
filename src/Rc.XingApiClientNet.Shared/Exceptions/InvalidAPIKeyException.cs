using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidAPIKeyException : XingException
{
    public InvalidAPIKeyException() : base("You provided an invalid api key.")
    {

    }
}
