using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidResourceIdException : XingException
{
    public InvalidResourceIdException() : base("The resource ID you specified in a read or update request was not a number. Maybe you used GET with a .../create-Request?")
    {

    }
}
