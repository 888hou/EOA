using EOA.Entity;
using EOA.Helper;
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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Menu menu)
        {
            return Ok(new Result
            {
                Code = ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _menuService.Add(menu)
                }
            });
        }

        [HttpGet]
        public async Task<IActionResult> Del(long id)
        {
            return Ok(new Result
            {
                Code = ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _menuService.Del(id)
                }
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Menu menu)
        {
            return Ok(new Result
            {
                Code = ResultCode.Success,
                Message = "",
                Obj = new
                {
                    RowCount = await _menuService.Edit(menu)
                }
            });
        }

        [HttpGet]
        public async Task<IActionResult> ListMenu()
        {
            try
            {
                return Ok(new Result
                {
                    Code = ResultCode.Success,
                    Message = "",
                    Obj = new
                    {
                        MenuTree = await _menuService.ListMenu()
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(ResultHelper.GetExResult(ex));
            }
        }
    }
}
