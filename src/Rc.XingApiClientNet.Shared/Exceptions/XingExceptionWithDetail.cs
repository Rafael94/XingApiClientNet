using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class XingExceptionWithDetail : XingException
{
    public XingExceptionWithDetail(string error, string message) : base($"{message}{Environment.NewLine}{error.Substring(error.LastIndexOf('.') + 1)}")
    {
    }
}
