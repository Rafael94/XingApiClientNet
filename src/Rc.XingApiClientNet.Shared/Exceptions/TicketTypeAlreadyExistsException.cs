using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class TicketTypeAlreadyExistsException : XingException
{
    public TicketTypeAlreadyExistsException() : base ("This type already exists. You have to update the existing one to activate it.")
    {

    }
}
