using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoHtmlContentAllowedException : XingException
{
    public NoHtmlContentAllowedException() : base("You tried to set the htmlContent of a plaintext email.")
    {

    }
}
