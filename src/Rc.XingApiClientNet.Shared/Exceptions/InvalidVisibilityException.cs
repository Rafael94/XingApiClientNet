using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidVisibilityException : XingException
{
    public InvalidVisibilityException() :  base("You're trying to update the property visibility, but the value you provided was invalid.")
    {

    }
}
