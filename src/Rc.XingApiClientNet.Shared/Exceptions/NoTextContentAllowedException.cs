using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class NoTextContentAllowedException : XingException
{
    public NoTextContentAllowedException() : base("You tried to set the textContent of a template email.")
    {

    }
}
