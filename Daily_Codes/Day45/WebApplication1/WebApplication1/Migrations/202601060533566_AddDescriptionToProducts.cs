namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductsTable", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductsTable", "Description");
        }
    }
}
