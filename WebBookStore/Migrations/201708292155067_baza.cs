namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookModels",
                c => new
                    {
                        BookModelID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(maxLength: 13, fixedLength: true, unicode: false),
                        Title = c.String(nullable: false, maxLength: 5, unicode: false),
                        Author = c.String(maxLength: 5, unicode: false),
                        Genre = c.String(maxLength: 5, unicode: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BookModelID);
            
            CreateTable(
                "dbo.ImageT",
                c => new
                    {
                        ImageModelID = c.Int(nullable: false),
                        isLogImage = c.Boolean(nullable: false),
                        Description = c.String(),
                        Picture = c.Binary(),
                        BookModel_BookModelID = c.Int(),
                    })
                .PrimaryKey(t => t.ImageModelID)
                .ForeignKey("dbo.BookModels", t => t.BookModel_BookModelID)
                .ForeignKey("dbo.UserAccountT", t => t.ImageModelID)
                .Index(t => t.ImageModelID)
                .Index(t => t.BookModel_BookModelID);
            
            CreateTable(
                "dbo.UserAccountT",
                c => new
                    {
                        UserAccountModelID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 10, unicode: false),
                        Password = c.String(nullable: false, maxLength: 10, unicode: false),
                        Mail = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserAccountModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImageT", "ImageModelID", "dbo.UserAccountT");
            DropForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels");
            DropIndex("dbo.ImageT", new[] { "BookModel_BookModelID" });
            DropIndex("dbo.ImageT", new[] { "ImageModelID" });
            DropTable("dbo.UserAccountT");
            DropTable("dbo.ImageT");
            DropTable("dbo.BookModels");
        }
    }
}
