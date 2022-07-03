using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet;

public class ExistsResponse : GeneralResponse
{
    public bool Exists { get; set; }
}
