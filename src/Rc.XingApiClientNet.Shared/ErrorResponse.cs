using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet;

public class ErrorResponse : GeneralResponse
{
    public List<string>? Errors { get; set; } 
}
