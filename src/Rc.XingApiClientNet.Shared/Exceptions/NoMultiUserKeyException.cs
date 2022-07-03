using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoMultiUserKeyException : XingException
{
    public NoMultiUserKeyException() : base("You are trying to request permission with an API key that already has a user permission and that is not a multi-user-API key.")
    {

    }
}
