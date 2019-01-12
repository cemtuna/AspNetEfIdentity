using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityWebUI.Models
{
    public class AccountDbContext:IdentityDbContext<DssUser>
    {
        public AccountDbContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DSS");
            base.OnModelCreating(modelBuilder);
        }
    }
}