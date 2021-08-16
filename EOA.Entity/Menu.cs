using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    public class Menu
    {
        [Key]
        public long MenuId { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Url { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Path { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Src { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Component { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string IconCls { get; set; }
        public bool KeepAlive { get; set; }
        public bool RequireAuth { get; set; }
        [Column(TypeName = "bigint")]
        public long ParentId { get; set; }
        public bool Enabled { get; set; }
        public long? ModifyBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ModifyDate { get; set; }

        #region
        public User ModifyUser { get; set; }
        [NotMapped]
        public ICollection<Role> Roles { get; set; }
        public List<RoleMenu> RoleMenus { get; set; }
        #endregion
    }
}
