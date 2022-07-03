using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public class InvalidOnlineTypeForThisEventException : XingException
{
    public InvalidOnlineTypeForThisEventException() : base("You tried to update the onlineType (ONLINE, OFFLINE, HYBRID) of a category which is invalid. In \"offline\" events no category can be ONLINE and in \"online\" events no category is allowed to be OFFLINE.")
    {

    }
}
