namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promenaBazea7asd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
            CreateIndex("dbo.ImageT", "ImageModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
    }
}
