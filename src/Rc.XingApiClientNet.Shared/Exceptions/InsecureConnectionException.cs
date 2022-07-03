using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InsecureConnectionException : XingException
{
    public InsecureConnectionException() : base("You called a method that has a user password as parameter. For security reasons, this method only works using a secure connection.")
    {

    }
}
