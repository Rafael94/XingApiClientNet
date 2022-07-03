using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class MissingParameterException : XingExceptionWithDetail
{
    public MissingParameterException(string error) : base(error, "You didn't provide a required parameter.")
    {

    }
}
