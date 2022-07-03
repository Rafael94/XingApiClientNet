using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Entities;

public class Event : BaseEntity
{
    public override string EntityName => "event";
    public int? HostId { get; set; }
    public string Title { get; set; } = default!;
    
}

public class EventFindFilter
{
    public int? Identifier { get; set; }
}
