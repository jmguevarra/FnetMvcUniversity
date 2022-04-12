using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FnetMvcUniversity.Entities
{
    public partial class EntStudentModel : DbContext
    {
        public EntStudentModel()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
