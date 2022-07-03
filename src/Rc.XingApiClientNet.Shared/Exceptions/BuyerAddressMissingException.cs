using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class BuyerAddressMissingException : XingException
{
    public BuyerAddressMissingException() : base("You tried to charge a paymetn without a buyerAdress.")
    {

    }
}
