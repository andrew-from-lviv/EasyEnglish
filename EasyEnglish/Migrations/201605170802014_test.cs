namespace EasyEnglish.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Cards",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.Int(nullable: false),
            //            Question = c.String(nullable: false, maxLength: 256),
            //            Answer = c.String(nullable: false, maxLength: 256),
            //            Note = c.String(maxLength: 512),
            //            CreatedAt = c.DateTime(nullable: false),
            //            ReviewedAt = c.DateTime(nullable: false),
            //            ReviewLevel = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //DropTable("dbo.Questions");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.Questions",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.Int(nullable: false),
            //            Word = c.String(nullable: false, maxLength: 128),
            //            Meaning = c.String(nullable: false, maxLength: 256),
            //            Note = c.String(maxLength: 512),
            //            CreatedAt = c.DateTime(nullable: false),
            //            ReviewedAt = c.DateTime(nullable: false),
            //            ReviewLevel = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //DropTable("dbo.Cards");
        }
    }
}
