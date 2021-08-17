using EOA.Entity;
using EOA.Model.ResultModel;
using EOA.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EOA.Api.Controllers
{
    /// <summary>
    /// 用户
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            return Ok(new Result
            {
                Code = (int)ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _userService.Add(user)
                }
            });
        }

        [HttpGet]
        public async Task<IActionResult> Del(long id)
        {
            return Ok(new Result
            {
                Code = (int)ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _userService.Del(id)
                }
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            return Ok(new Result
            {
                Code = (int)ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _userService.Edit(user)
                }
            });
        }
    }
}
