using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoLanguageException : XingException
{
    public NoLanguageException() : base("The object or user has no language set.")
    {
         
    }
}
