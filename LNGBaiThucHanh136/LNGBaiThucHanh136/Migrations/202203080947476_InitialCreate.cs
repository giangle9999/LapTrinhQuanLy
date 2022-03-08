namespace LNGBaiThucHanh136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Student5s",
                c => new
                    {
                        Student5ID = c.String(nullable: false, maxLength: 128),
                        Student5Name = c.String(),
                    })
                .PrimaryKey(t => t.Student5ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 50, unicode: false),
                        StudentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.Student5s");
            DropTable("dbo.Persons");
            DropTable("dbo.Employees");
        }
    }
}
