namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updategenelmd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika");
            DropIndex("dbo.genelmd", new[] { "FabrikaId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.genelmd", "FabrikaId");
            AddForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika", "Id");
        }
    }
}
