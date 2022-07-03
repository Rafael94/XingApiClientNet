using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class RegistrationDeadlineInvalidException : XingException
{
    public RegistrationDeadlineInvalidException() : base ("registrationEndDate is before registrationStartDate")
    {

    }
}
