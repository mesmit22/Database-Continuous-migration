namespace database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDonetoComplete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todo", "Complete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Todo", "Done");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todo", "Done", c => c.Boolean(nullable: false));
            DropColumn("dbo.Todo", "Complete");
        }
    }
}
