using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidPasswordException : XingException
{
    public InvalidPasswordException() : base("The password you've sent doesn't match the user.")
    {

    }
}
