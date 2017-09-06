namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ImageT", "ImageModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
    }
}
