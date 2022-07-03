using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NameMissingException : XingException
{
    public NameMissingException() : base("	You tried to create or update a ticket category without a name.")
    {

    }
}
