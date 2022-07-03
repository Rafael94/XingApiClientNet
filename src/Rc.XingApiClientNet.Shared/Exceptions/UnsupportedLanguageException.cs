using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class UnsupportedLanguageException : XingException
{
    public UnsupportedLanguageException() : base("The language you provided is not supported by XING Events.")
    {

    }
}
