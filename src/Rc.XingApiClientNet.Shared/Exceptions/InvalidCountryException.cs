using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidCountryException : XingException
{
    public InvalidCountryException() : base("The value you provided for a country user field is not valid.")
    {

    }
}
