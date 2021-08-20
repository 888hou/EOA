using EOA.Model.ResultModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EOA.Helper
{
    public static class ResultHelper
    {
        public static Result GetExResult(Exception ex)
        {
            return new Result
            {
                Code = ResultCode.Success,
                Message = ex.Message + ex.StackTrace,
                Obj = null
            };
        }
    }
}
