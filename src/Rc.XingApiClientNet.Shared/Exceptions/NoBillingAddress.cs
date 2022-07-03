using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoBillingAddress : XingException
{
    public NoBillingAddress() : base("The event has no billing address defined yet.")
    {

    }
}
