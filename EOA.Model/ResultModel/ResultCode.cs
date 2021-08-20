using System;
using System.Collections.Generic;
using System.Text;

namespace EOA.Model.ResultModel
{
    public static class ResultCode
    {
        public static int Success { get; } = 200;
        public static int Warning { get; } = 300;
        public static int Error { get; } = 400;
    }
}
