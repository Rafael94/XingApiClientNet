using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class TicketTypeNotAllowedException : XingException
{
    public TicketTypeNotAllowedException() : base("This type is not allowed for the event.")
    {

    }
}
