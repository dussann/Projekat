namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dorada : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels");
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            DropIndex("dbo.ImageT", new[] { "BookModel_BookModelID" });
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
            DropColumn("dbo.ImageT", "BookModel_BookModelID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ImageT", "BookModel_BookModelID", c => c.Int());
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
            CreateIndex("dbo.ImageT", "BookModel_BookModelID");
            CreateIndex("dbo.ImageT", "ImageModelID");
            AddForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT", "UserAccountModelID");
            AddForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels", "BookModelID");
        }
    }
}
