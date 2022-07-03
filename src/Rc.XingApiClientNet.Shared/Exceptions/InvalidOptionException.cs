using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidOptionException : XingException
{
    public InvalidOptionException() : base("The value you provided for a dropdown or radio button type user field is not valid.")
    {

    }
}
