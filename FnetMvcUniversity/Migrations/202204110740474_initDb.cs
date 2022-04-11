namespace FnetMvcUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StudLRN = c.String(),
                        FullName = c.String(nullable: false),
                        StudCourse = c.String(nullable: false),
                        StudYear = c.Int(nullable: false),
                        StudSection = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
