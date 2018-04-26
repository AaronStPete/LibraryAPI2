namespace LibraryAPI2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCheckoutLedgers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckoutLedgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        Email = c.String(),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckoutLedgers", "BookId", "dbo.Books");
            DropIndex("dbo.CheckoutLedgers", new[] { "BookId" });
            DropTable("dbo.CheckoutLedgers");
        }
    }
}
