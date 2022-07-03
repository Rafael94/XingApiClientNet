using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTitleException : XingException
{
    public NoTitleException() : base ("The event has no title set.")
    {

    }
}
