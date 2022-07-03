using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class TicketsRequiredException: XingException
{
    public TicketsRequiredException() : base("You tried to start a payment without selecting any ticket.")
    {

    }
}
