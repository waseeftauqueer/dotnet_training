namespace CodeFIrstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InititalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLs",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: false),
                        TeamName = c.String(),
                        Captain = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.TeamID);
            
            CreateTable(
                "dbo.StudentsTable",
                c => new
                    {
                        SId = c.Int(nullable: false),
                        SName = c.String(nullable: false, maxLength: 30, unicode: false),
                        DOBDate = c.DateTime(nullable: false),
                        Class = c.Int(nullable: false),
                        SEmail = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentsTable");
            DropTable("dbo.IPLs");
        }
    }
}
