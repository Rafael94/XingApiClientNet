using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidNumberException : XingException
{
    public InvalidNumberException() : base("The value you provided for a number type user field is not valid.")
    {

    }
}
