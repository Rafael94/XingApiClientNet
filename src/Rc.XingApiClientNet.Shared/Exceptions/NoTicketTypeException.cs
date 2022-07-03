using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTicketTypeException : XingException
{
    public NoTicketTypeException() : base("The event has no ticket types (e-ticket, paper, etc.) defined yet.")
    {

    }
}
