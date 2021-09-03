using EOA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EOA.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        //public DbSet<Captcha> Captcha { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        #region 关系
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 添加ModifyBy外键
            modelBuilder.Entity<Menu>()
                .HasOne(t => t.ModifyUser)
                .WithOne()
                .HasForeignKey<Menu>(t => t.ModifyBy)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Role>()
                .HasOne(t => t.ModifyUser)
                .WithOne()
                .HasForeignKey<Role>(t => t.ModifyBy)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasOne(t => t.ModifyUser)
                .WithOne()
                .HasForeignKey<User>(t => t.ModifyBy)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserRole>()
               .HasOne(t => t.ModifyUser)
               .WithOne()
               .HasForeignKey<UserRole>(t => t.ModifyBy)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<RoleMenu>()
               .HasOne(t => t.ModifyUser)
               .WithOne()
               .HasForeignKey<RoleMenu>(t => t.ModifyBy)
               .OnDelete(DeleteBehavior.SetNull);
            #endregion

            modelBuilder.Entity<UserRole>()
                .HasKey(t => new { t.UserId, t.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoleMenu>()
                .HasKey(t => new { t.RoleId, t.MenuId });

            modelBuilder.Entity<RoleMenu>()
                .HasOne(rm => rm.Role)
                .WithMany(r => r.RoleMenus)
                .HasForeignKey(rm => rm.MenuId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoleMenu>()
                .HasOne(rm => rm.Menu)
                .WithMany(m => m.RoleMenus)
                .HasForeignKey(rm => rm.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
