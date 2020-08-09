namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Identityuser : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Kullanici");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Guid = c.String(maxLength: 50),
                        IlkKayitIP = c.String(maxLength: 50),
                        IlkKayitTarihi = c.DateTime(nullable: false),
                        IlkKayitKullaniciID = c.Int(nullable: false),
                        SonKayitIP = c.String(maxLength: 50),
                        SonKayitTarihi = c.DateTime(),
                        SonKayitKullaniciID = c.Int(),
                        Silindi = c.Boolean(),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 150),
                        Soyadi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
