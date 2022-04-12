using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FnetMvcUniversity.Models
{
    public class FnetMvcUniDbContext : DbContext
    {
        public FnetMvcUniDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer( new MigrateDatabaseToLatestVersion<FnetMvcUniDbContext, Migrations.Configuration>("DefaultConnection") );
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}