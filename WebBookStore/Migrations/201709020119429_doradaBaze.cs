namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doradaBaze : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ImageT");
            AddColumn("dbo.ImageT", "BookModel_BookModelID", c => c.Int());
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
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
            DropPrimaryKey("dbo.ImageT");
            AlterColumn("dbo.ImageT", "ImageModelID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.ImageT", "BookModel_BookModelID");
            AddPrimaryKey("dbo.ImageT", "ImageModelID");
        }
    }
}
