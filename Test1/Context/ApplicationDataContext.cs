using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test1.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}