using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class ErrorOnEvaluatingTemplateException : XingException
{
    public ErrorOnEvaluatingTemplateException() : base("An error on evaluating the template. Maybe you provided an invalid template name.")
    {

    }
}
