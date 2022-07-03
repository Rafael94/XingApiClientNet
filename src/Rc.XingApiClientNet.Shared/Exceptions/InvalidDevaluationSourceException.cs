using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidDevaluationSourceException : XingExceptionWithDetail
{
    public InvalidDevaluationSourceException(string error) : base (error, @"The value you provided as source does not exist.
Do not provide this optional parameter or use on the following valid source")
    {

    }
}
