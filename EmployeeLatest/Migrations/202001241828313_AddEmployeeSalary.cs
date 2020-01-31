namespace EmployeeLatest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeSalary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeSalaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.String(),
                        EmpId = c.Int(nullable: false),
                        DepaId = c.Int(nullable: false),
                        EmpName = c.String(),
                        DepaName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeSalaries", "EmpId", "dbo.Employees");
            DropIndex("dbo.EmployeeSalaries", new[] { "EmpId" });
            DropTable("dbo.EmployeeSalaries");
        }
    }
}
