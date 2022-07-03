using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class TicketSaleSpanIsTooBigException : XingException
{
    public TicketSaleSpanIsTooBigException() : base("You difference between maxSell and minSell is too big. maxSell - minSell must not be greater then 500.")
    {

    }
}
