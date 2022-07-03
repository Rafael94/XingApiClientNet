using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoUnsubscribeLinkException : XingException
{
    public NoUnsubscribeLinkException() : base("You forgot to include the unsubscribe link ([%unsubscribe%]).")
    {

    }
}
