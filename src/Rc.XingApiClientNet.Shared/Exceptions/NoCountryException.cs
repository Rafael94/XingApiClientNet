using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoCountryException : XingException
{
    public NoCountryException() : base("The event has no country set")
    {

    }
}
