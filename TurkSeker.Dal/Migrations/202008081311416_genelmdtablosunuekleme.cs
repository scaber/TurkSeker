namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genelmdtablosunuekleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.genelmd",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FabrikaId = c.Int(),
                        Kayit_tar_saat = c.DateTime(nullable: false),
                        Kiyim1_anlik_ton = c.Double(),
                        Kiyim2_anlik_ton = c.Double(),
                        Kiyim3_anlik_ton = c.Double(),
                        Ham_bek_sek = c.Double(),
                        Raf_bek_sek = c.Double(),
                        Top_bek_sek = c.Double(),
                        Bugun_cik_sek = c.Double(),
                        Dun_cik_sek = c.Double(),
                        Bugun_kes_pan = c.Double(),
                        Dun_kes_pan = c.Double(),
                        Kiyim_polu = c.Double(),
                        ToplamPancar = c.Double(),
                        BugunGelenPancar = c.Double(),
                        KantardakiPancar = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.genelmd");
        }
    }
}
