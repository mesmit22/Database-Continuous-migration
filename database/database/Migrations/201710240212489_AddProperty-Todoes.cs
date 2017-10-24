namespace database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyTodoes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todo", "DueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Todo", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todo", "Priority");
            DropColumn("dbo.Todo", "DueDate");
        }
    }
}
