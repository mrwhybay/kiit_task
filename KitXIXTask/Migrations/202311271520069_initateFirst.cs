namespace KitXIXTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initateFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Size = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MfgDate = c.DateTime(nullable: false),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Product");
        }
    }
}
