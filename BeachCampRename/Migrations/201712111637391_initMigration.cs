namespace BeachCampRename.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Account = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewNames");
        }
    }
}
