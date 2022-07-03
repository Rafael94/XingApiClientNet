using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class EventAlreadyActivatedException : XingException
{
    public EventAlreadyActivatedException() : base("You tried to activate an event, which has already been activated before.")
    {

    }
}
