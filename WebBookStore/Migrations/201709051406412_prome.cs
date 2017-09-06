namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prome : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
            CreateIndex("dbo.ImageT", "ImageModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
        }
    }
}
