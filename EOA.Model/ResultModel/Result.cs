using System;
using System.Collections.Generic;
using System.Text;

namespace EOA.Model.ResultModel
{
    public class Result
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public dynamic Obj { get; set; }
    }
}
