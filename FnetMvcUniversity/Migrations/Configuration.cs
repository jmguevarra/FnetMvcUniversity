namespace FnetMvcUniversity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FnetMvcUniversity.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<FnetMvcUniversity.Models.FnetMvcUniDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FnetMvcUniversity.Models.FnetMvcUniDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            List<Student> studentList = new List<Student>();
            studentList.Add( new Student() { StudLRN = "123456220000", FullName = "Jaira Mae De Dios", StudCourse="BSIT", StudSection="A", StudYear=1 } );
            studentList.Add( new Student() { StudLRN = "123456220001", FullName = "Jack Defensor", StudCourse = "BSPA", StudSection = "C", StudYear = 3 } );
            studentList.Add(new Student() { StudLRN = "123456220002", FullName = "Chai Mai Ong", StudCourse = "BSEntrep", StudSection = "B", StudYear = 2 });
            studentList.Add(new Student() { StudLRN = "123456220004", FullName = "Janela Lariosa", StudCourse = "HRS", StudSection = "A", StudYear = 4 });

            foreach (Student student in studentList) {
                context.Student.Add(student);
            }

            base.Seed(context);
        }
    }
}
