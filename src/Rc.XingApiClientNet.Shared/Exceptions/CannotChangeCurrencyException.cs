using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class CannotChangeCurrencyException : XingException
{
    public CannotChangeCurrencyException() : base("You can't change the currency of a ticket shop, if the event is not in demo mode anymore and has already sold tickets.")
    {

    }
}
