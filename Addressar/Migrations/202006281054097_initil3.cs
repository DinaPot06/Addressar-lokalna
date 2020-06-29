namespace Addressar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initil3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addressaris", "Surname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addressaris", "Surname");
        }
    }
}
