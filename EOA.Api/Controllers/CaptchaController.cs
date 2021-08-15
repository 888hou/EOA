using EOA.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EOA.Api.Controllers
{
    /// <summary>
    /// 验证码
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CaptchaController : ControllerBase
    {
        /// <summary>
        /// 获取随机验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<FileContentResult> GetCaptcha()
        {
            var code = await CaptchaHelper.GenerateRandomCaptchaAsync();

            var result = await CaptchaHelper.GenerateCaptchaImageAsync(code);

            return File(result.CaptchaMemoryStream.ToArray(), "image/png");
        }
    }
}
