using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoHtmlContentGivenException : XingException
{
    public NoHtmlContentGivenException() : base("There is no text in your HTML content.")
    {

    }
}
