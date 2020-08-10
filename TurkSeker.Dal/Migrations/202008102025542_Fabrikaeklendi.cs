namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fabrikaeklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fabrika",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FabrikaAdi = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.genelmd", "FabrikaId");
            AddForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.genelmd", "FabrikaId", "dbo.Fabrika");
            DropIndex("dbo.genelmd", new[] { "FabrikaId" });
            DropTable("dbo.Fabrika");
        }
    }
}
