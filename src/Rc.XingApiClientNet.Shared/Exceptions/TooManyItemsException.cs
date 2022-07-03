using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class TooManyItemsException : XingException
{
    public TooManyItemsException() : base("You provided an amount of tickets that is greater than the number of avalible tickets.")
    {

    }
}
