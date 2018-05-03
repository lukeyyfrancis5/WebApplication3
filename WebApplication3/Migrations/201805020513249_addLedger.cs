namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLedger : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ledgers", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ledgers", "Time", c => c.DateTime(nullable: true));
        }
    }
}
