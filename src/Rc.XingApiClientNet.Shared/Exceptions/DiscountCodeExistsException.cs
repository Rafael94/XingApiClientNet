using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DiscountCodeExistsException : XingException
{
    public DiscountCodeExistsException() : base("You tried to add a code to the CodeDefinition that already exists in this event.")
    {

    }
}
