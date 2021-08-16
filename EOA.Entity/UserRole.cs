using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    public class UserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public string ApplyReason { get; set; }
        public long? ModifyBy { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }

        #region relation
        public User ModifyUser { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion
    }
}
