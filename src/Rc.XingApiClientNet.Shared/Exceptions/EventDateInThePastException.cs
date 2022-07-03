using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class EventDateInThePastException : XingException
{
    public EventDateInThePastException() : base("The date of the event can not be in the past.")
    {

    }
}
