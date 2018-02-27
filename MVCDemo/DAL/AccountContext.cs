using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext():base("AccountContext")
        {

        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }
    }
}