namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promenaBaze : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            AddColumn("dbo.ImageT", "UserAccountModel_UserAccountModelID", c => c.Int());
            CreateIndex("dbo.ImageT", "UserAccountModel_UserAccountModelID");
            AddForeignKey("dbo.ImageT", "UserAccountModel_UserAccountModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImageT", "UserAccountModel_UserAccountModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "UserAccountModel_UserAccountModelID" });
            DropColumn("dbo.ImageT", "UserAccountModel_UserAccountModelID");
            CreateIndex("dbo.ImageT", "ImageModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
    }
}
