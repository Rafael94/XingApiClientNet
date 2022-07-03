using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet;

public abstract class BaseEntity
{
    public abstract string EntityName { get; }

    public int Id { get; }
}
