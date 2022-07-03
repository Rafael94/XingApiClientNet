using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InternalServerException : XingExceptionWithDetail
{
    public InternalServerException(string error) : base(error, "An internal error has occurred on our server. Please contact api@xing-events.com using the returned error id to report this error.") 
    {

    }
}
