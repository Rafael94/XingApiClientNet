using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet;

public class FindResponse : GeneralResponse
{
    public List<uint> Ids { get; set; } = default!;
}
