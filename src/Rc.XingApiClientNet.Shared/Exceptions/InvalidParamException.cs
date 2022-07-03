using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

internal class InvalidParamException : XingExceptionWithDetail
{
    public InvalidParamException(string error) : base(error, "The parameter <property> you provided is not valid for this request.")
    {

    }
}
