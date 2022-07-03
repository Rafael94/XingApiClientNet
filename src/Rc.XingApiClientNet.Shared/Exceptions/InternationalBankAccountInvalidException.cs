using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InternationalBankAccountInvalidException : XingException
{
    public InternationalBankAccountInvalidException() : base("You tried to add/update a non-German bank account while not being whitelisted for this action. Please contact offers@xing-events.com if you'd like to become whitelisted for international bank accounts.")
    {

    }
}
