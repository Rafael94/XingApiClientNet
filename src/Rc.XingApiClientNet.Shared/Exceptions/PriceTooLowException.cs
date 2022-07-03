using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class PriceTooLowException : XingException
{
    public PriceTooLowException() : base("You tried to create or update a ticket category with a price that is too low.")
    {

    }
}
