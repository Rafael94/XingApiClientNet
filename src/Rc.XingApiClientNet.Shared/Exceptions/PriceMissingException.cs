using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions; 

public class PriceMissingException : XingException
{
    public PriceMissingException() : base("You tried to create or update a ticket category without a price.")
    {

    }
}
