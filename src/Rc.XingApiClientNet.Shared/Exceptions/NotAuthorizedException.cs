using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NotAuthorizedException : XingException
{
    public NotAuthorizedException() : base("You tried to access an object where you do not have the necessary permissions.")
    {
    }
}
