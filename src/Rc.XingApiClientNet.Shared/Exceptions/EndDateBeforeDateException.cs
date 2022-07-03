using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class EndDateBeforeDateException : XingException
{
    public EndDateBeforeDateException() : base("The end date of the event is before the start date.")
    {

    }
}
