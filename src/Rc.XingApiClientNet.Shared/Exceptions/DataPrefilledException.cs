using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class DataPrefilledException : XingException
{
    public DataPrefilledException() : base("This payment has already data prefiled.")
    {

    }
}
