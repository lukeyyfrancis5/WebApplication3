namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Ledgers",
                c => new
                    {
                        LedgerId = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Account_AccountId = c.Int(),
                    })
                .PrimaryKey(t => t.LedgerId)
                .ForeignKey("dbo.Accounts", t => t.Account_AccountId)
                .Index(t => t.Account_AccountId);
            
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        CoinId = c.Int(nullable: false, identity: true),
                        Symbol = c.String(),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Ledger_LedgerId = c.Int(),
                    })
                .PrimaryKey(t => t.CoinId)
                .ForeignKey("dbo.Ledgers", t => t.Ledger_LedgerId)
                .Index(t => t.Ledger_LedgerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "Ledger_LedgerId", "dbo.Ledgers");
            DropForeignKey("dbo.Ledgers", "Account_AccountId", "dbo.Accounts");
            DropIndex("dbo.Coins", new[] { "Ledger_LedgerId" });
            DropIndex("dbo.Ledgers", new[] { "Account_AccountId" });
            DropTable("dbo.Coins");
            DropTable("dbo.Ledgers");
            DropTable("dbo.Accounts");
        }
    }
}
