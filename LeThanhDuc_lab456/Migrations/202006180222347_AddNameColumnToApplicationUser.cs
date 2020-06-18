namespace LeThanhDuc_lab456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
           
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "Category_RequireUniqueEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Category_RequireUniqueEmail", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
