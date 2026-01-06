namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductsTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Sales_SaleID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sales", t => t.Sales_SaleID)
                .Index(t => t.Sales_SaleID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleID = c.Int(nullable: false, identity: true),
                        SaleDate = c.DateTime(nullable: false),
                        Qty = c.Int(nullable: false),
                        SaleTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SaleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsTable", "Sales_SaleID", "dbo.Sales");
            DropIndex("dbo.ProductsTable", new[] { "Sales_SaleID" });
            DropTable("dbo.Sales");
            DropTable("dbo.ProductsTable");
        }
    }
}
