namespace Repository_Pattern_Application_CC08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(nullable: false),
                        DirectorName = c.String(nullable: false),
                        DateOfRelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
