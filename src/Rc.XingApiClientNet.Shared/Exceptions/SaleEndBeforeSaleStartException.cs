using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class SaleEndBeforeSaleStartException : XingException
{
    public SaleEndBeforeSaleStartException() : base("You provided a end date that is before the start date.")
    {

    }
}
