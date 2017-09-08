namespace WebBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class opetnovabazaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels");
            DropForeignKey("dbo.ImageT", "UserAccountModel_UserAccountModelID", "dbo.UserAccountT");
            DropIndex("dbo.ImageT", new[] { "BookModel_BookModelID" });
            DropIndex("dbo.ImageT", new[] { "UserAccountModel_UserAccountModelID" });
            AddColumn("dbo.BookModels", "Description", c => c.String());
            AddColumn("dbo.BookModels", "Picture", c => c.Binary());
            AddColumn("dbo.UserAccountT", "Description", c => c.String());
            AddColumn("dbo.UserAccountT", "Picture", c => c.Binary());
            DropTable("dbo.ImageT");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ImageT",
                c => new
                    {
                        ImageModelID = c.Int(nullable: false, identity: true),
                        isLogImage = c.Boolean(nullable: false),
                        Description = c.String(),
                        Picture = c.Binary(),
                        BookModel_BookModelID = c.Int(),
                        UserAccountModel_UserAccountModelID = c.Int(),
                    })
                .PrimaryKey(t => t.ImageModelID);
            
            DropColumn("dbo.UserAccountT", "Picture");
            DropColumn("dbo.UserAccountT", "Description");
            DropColumn("dbo.BookModels", "Picture");
            DropColumn("dbo.BookModels", "Description");
            CreateIndex("dbo.ImageT", "UserAccountModel_UserAccountModelID");
            CreateIndex("dbo.ImageT", "BookModel_BookModelID");
            AddForeignKey("dbo.ImageT", "UserAccountModel_UserAccountModelID", "dbo.UserAccountT", "UserAccountModelID");
            AddForeignKey("dbo.ImageT", "BookModel_BookModelID", "dbo.BookModels", "BookModelID");
        }
    }
}
