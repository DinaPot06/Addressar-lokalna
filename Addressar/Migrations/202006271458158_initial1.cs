namespace Addressar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Addressars", newName: "Addressaris");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Addressaris", newName: "Addressars");
        }
    }
}
