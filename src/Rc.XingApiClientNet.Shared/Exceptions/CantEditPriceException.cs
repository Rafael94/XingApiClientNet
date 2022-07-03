using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class CantEditPriceException : XingException
{
    public CantEditPriceException() : base("You tried to update the price of a category whose associated event is not in demo mode and tickets where already sold.")
    {

    }
}
