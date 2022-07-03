using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class ObjectNotFoundException : XingException
{
    public ObjectNotFoundException() : base("The object you requested could not be found.")
    {

    }
}
