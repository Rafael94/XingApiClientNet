using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class CommentTooLongException : XingException
{
    public CommentTooLongException() : base("	You provided a comment that is too long.")
    {

    }
}
