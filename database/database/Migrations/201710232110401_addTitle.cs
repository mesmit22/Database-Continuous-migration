namespace database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTitle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TodoTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todo");
        }
    }
}
