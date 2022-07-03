using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTicketCategoriesException : XingException
{
    public NoTicketCategoriesException() : base(@"The event has no ticket categories defined yet.
Use TicketCategory Create to add categories to your event.")
    {

    }
}
