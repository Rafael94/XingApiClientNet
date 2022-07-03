using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet;

public class DeleteResponse : GeneralResponse
{
    public bool Deleted { get; set; }
}
