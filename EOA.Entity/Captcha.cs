using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    /// <summary>
    /// 验证码
    /// </summary>
    public class Captcha
    {
        public long CaptchaId { get; set; }
        [Column(TypeName = "text")]
        [Required]
        public string CaptchaSrc { get; set; }
        [Column(TypeName = "varchar(4)")]
        [Required]
        public string CaptchaCode { get; set; }
    }
}
