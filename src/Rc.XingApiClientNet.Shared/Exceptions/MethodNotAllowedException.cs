using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class MethodNotAllowedException : XingException
{
    public MethodNotAllowedException() : base("You tried to mark a payment as paid that is handled by XING Events. Only payments that used a payment option handled by the organizer can be marked as paid.")
    {

    }
}
