namespace BlogCoreMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(nullable: false),
                        Title = c.String(maxLength: 75),
                        MetaTile = c.String(maxLength: 100),
                        Slug = c.String(maxLength: 100),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryID, t.PostID })
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        ParentID = c.Int(nullable: false),
                        Title = c.String(maxLength: 75),
                        MetaTile = c.String(maxLength: 100),
                        Slug = c.String(maxLength: 100),
                        Sumary = c.String(),
                        PubLished = c.Int(nullable: false),
                        CreateAT = c.DateTime(nullable: false),
                        UpdateAT = c.DateTime(nullable: false),
                        PublishedAT = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.User", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        PostCommentID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        ParentID = c.Int(nullable: false),
                        Title = c.String(maxLength: 100),
                        Published = c.Int(nullable: false),
                        CreateAT = c.DateTime(nullable: false),
                        PublishedAT = c.DateTime(nullable: false),
                        Content = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostCommentID)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.PostID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        PassWord = c.String(maxLength: 32),
                        Registered = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        InTro = c.String(),
                        Profile = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.PostMetas",
                c => new
                    {
                        PostMetaID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        Key = c.String(maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.PostMetaID)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                        Key = c.String(maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 75),
                        MetaTile = c.String(maxLength: 100),
                        Content = c.String(),
                        Tag_TagID = c.Int(),
                    })
                .PrimaryKey(t => t.TagID)
                .ForeignKey("dbo.Tag", t => t.Tag_TagID)
                .Index(t => t.Tag_TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tag", "Tag_TagID", "dbo.Tag");
            DropForeignKey("dbo.Post", "AuthorID", "dbo.User");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Post");
            DropForeignKey("dbo.PostMetas", "PostID", "dbo.Post");
            DropForeignKey("dbo.PostComments", "UserID", "dbo.User");
            DropForeignKey("dbo.PostComments", "PostID", "dbo.Post");
            DropForeignKey("dbo.PostCategories", "PostID", "dbo.Post");
            DropForeignKey("dbo.PostCategories", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Tag", new[] { "Tag_TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.PostMetas", new[] { "PostID" });
            DropIndex("dbo.PostComments", new[] { "UserID" });
            DropIndex("dbo.PostComments", new[] { "PostID" });
            DropIndex("dbo.Post", new[] { "AuthorID" });
            DropIndex("dbo.PostCategories", new[] { "PostID" });
            DropIndex("dbo.PostCategories", new[] { "CategoryID" });
            DropTable("dbo.Tag");
            DropTable("dbo.PostTags");
            DropTable("dbo.PostMetas");
            DropTable("dbo.User");
            DropTable("dbo.PostComments");
            DropTable("dbo.Post");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Categories");
        }
    }
}
