namespace TestApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EmploymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                        Employee_ID = c.Int(),
                        Project_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_ID)
                .ForeignKey("dbo.Projects", t => t.Project_ID)
                .Index(t => t.Employee_ID)
                .Index(t => t.Project_ID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Key = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Project_ID", "dbo.Projects");
            DropForeignKey("dbo.Tasks", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.Tasks", new[] { "Project_ID" });
            DropIndex("dbo.Tasks", new[] { "Employee_ID" });
            DropTable("dbo.Projects");
            DropTable("dbo.Tasks");
            DropTable("dbo.Employees");
        }
    }
}
