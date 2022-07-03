using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidSignUpPromotionCodeException : XingException
{
    public InvalidSignUpPromotionCodeException() : base("You are trying to create a user object, but the sign up promotion code was incorrect. The user was not created.")
    {

    }
}
