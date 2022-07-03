using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidPathException : XingException
{
    public InvalidPathException() : base("You specified an invalid url or used the wrong REST method in your call (GET versus POST)")
    {

    }
}
