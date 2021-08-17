using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EOA.Entity
{
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
            UserRoles = new List<UserRole>();
        }
        [Key]
        public long UserId { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string PhoneNum { get; set; }
        [Column(TypeName = "text")]
        public string Avatar { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? PromoteDate { get; set; }
        public long? ModifyBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ModifyDate { get; set; }

        #region
        public User ModifyUser { get; set; }
        [NotMapped]
        public List<Role> Roles { get; set; }
        public List<UserRole> UserRoles { get; set; }
        #endregion
    }
}
