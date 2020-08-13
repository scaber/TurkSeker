namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.genelmd", "FabrikaId");
            AddForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika");
            DropIndex("dbo.genelmd", new[] { "FabrikaId" });
        }
    }
}
