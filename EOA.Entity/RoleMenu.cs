using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    public class RoleMenu
    {
        public long RoleId { get; set; }
        public long MenuId { get; set; }
        public bool ReadOnly { get; set; }
        public long? ModifyBy { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }

        #region relations
        public User ModifyUser { get; set; }
        public Role Role { get; set; }
        public Menu Menu { get; set; }
        #endregion
    }
}
