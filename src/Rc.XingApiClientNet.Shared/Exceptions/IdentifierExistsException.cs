using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class IdentifierExistsException: XingException
{
    public IdentifierExistsException() : base("You're trying to update the public event identifier, but the value is already in use.")
    {

    }
}
