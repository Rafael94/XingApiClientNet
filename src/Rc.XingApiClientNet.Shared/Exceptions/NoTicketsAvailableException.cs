using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTicketsAvailableException : XingException
{
    public NoTicketsAvailableException() : base("You tried to create or update a ticket category with 0 tickets.")
    {

    }
}
