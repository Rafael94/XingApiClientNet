using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoBankAccountException : XingException
{
    public NoBankAccountException() : base("The event has no bank account defined yet.")
    {

    }
}
