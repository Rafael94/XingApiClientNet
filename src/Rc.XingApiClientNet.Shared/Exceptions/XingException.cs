using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public abstract class XingException : Exception
{
    public XingException(string message) : base(message)
    {
        HelpLink = "https://developers.xing-events.com/index.php/REST_API_ErrorCodes";
    }
}
