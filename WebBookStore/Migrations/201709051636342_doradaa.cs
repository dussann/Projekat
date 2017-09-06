namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doradaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageT", "BookModel_BookModelID", c => c.Int());
            CreateIndex("dbo.ImageT", "ImageModelID");
            CreateIndex("dbo.ImageT", "BookModel_BookModelID");
            AddForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels", "BookModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels");
            DropIndex("dbo.ImageT", new[] { "BookModel_BookModelID" });
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            DropColumn("dbo.ImageT", "BookModel_BookModelID");
        }
    }
}
