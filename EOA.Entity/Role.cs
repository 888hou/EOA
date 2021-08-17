using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
            Menus = new List<Menu>();
            UserRoles = new List<UserRole>();
            RoleMenus = new List<RoleMenu>();
        }
        [Key]
        public long RoleId { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public long? ModifyBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ModifyDate { get; set; }

        #region
        public User ModifyUser { get; set; }
        [NotMapped]
        public List<User> Users { get; set; }
        public List<UserRole> UserRoles { get; set; }
        [NotMapped]
        public List<Menu> Menus { get; set; }
        public List<RoleMenu> RoleMenus { get; set; }
        #endregion
    }
}
