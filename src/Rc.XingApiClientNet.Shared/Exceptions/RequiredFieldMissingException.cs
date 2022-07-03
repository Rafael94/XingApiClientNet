using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class RequiredFieldMissingException : XingExceptionWithDetail
{
    public RequiredFieldMissingException(string error) : base(error, @"You are trying to create or to update an user object and didn't provide the property <field>.
NOTE: If you get the Errorcode com.amiando.User.IdentifierRequired, you didn't provide the property username.
")
    {

    }
}
