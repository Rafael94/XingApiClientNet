using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class UnsupportedCountryException :XingException
{
    public UnsupportedCountryException() : base("The country code you provided is invalid.")
    {

    }
}
