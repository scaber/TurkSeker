namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fabrika", "genelmd_Id", "dbo.genelmd");
            DropIndex("dbo.Fabrika", new[] { "genelmd_Id" });
            DropColumn("dbo.Fabrika", "genelmd_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fabrika", "genelmd_Id", c => c.Int());
            CreateIndex("dbo.Fabrika", "genelmd_Id");
            AddForeignKey("dbo.Fabrika", "genelmd_Id", "dbo.genelmd", "Id");
        }
    }
}
