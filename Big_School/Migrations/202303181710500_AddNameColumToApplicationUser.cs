namespace Big_School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "DateTime", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
