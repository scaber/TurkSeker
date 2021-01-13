namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class burdurscada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.burdurscada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        burstandartdeposeviye = c.Double(),
                        burortasurupdeposeviye = c.Double(),
                        burkristalyesildeposeviye = c.Double(),
                        burkristalbeyazdeposeviye = c.Double(),
                        burA1seviye = c.Double(),
                        burA1Bx = c.Double(),
                        burA2seviye = c.Double(),
                        burA2Bx = c.Double(),
                        burA3seviye = c.Double(),
                        burA3Bx = c.Double(),
                        burA4seviye = c.Double(),
                        burA4Bx = c.Double(),
                        burA5seviye = c.Double(),
                        burA5Bx = c.Double(),
                        burA6seviye = c.Double(),
                        burA6Bx = c.Double(),
                        burA7seviye = c.Double(),
                        burA7Bx = c.Double(),
                        burKrstaltevsev1 = c.Double(),
                        burKrstaltevsev2 = c.Double(),
                        burKrstalrefsev1 = c.Double(),
                        burKrstalrefsev2 = c.Double(),
                        burKrstalrefsev3 = c.Double(),
                        burB1seviye = c.Double(),
                        burB1Bx = c.Double(),
                        burB2seviye = c.Double(),
                        burB2Bx = c.Double(),
                        burB3seviye = c.Double(),
                        burB3Bx = c.Double(),
                        burB4seviye = c.Double(),
                        burB4Bx = c.Double(),
                        burC1seviye = c.Double(),
                        burC1Bx = c.Double(),
                        burC2seviye = c.Double(),
                        burC2Bx = c.Double(),
                        burC3seviye = c.Double(),
                        burC3Bx = c.Double(),
                        burC4seviye = c.Double(),
                        burC4Bx = c.Double(),
                        burC5seviye = c.Double(),
                        burC5Bx = c.Double(),
                        burOrtaTevsev = c.Double(),
                        burOrtaRefsev1 = c.Double(),
                        burOrtaRefsev2 = c.Double(),
                        burSonTevsev1 = c.Double(),
                        burSonTevsev2 = c.Double(),
                        burDifuzyonKule1sev = c.Double(),
                        burDifuzyonKule1Devir = c.Double(),
                        burDifuzyonKule1Akim = c.Double(),
                        burDifuzyonKule2sev = c.Double(),
                        burDifuzyonKule2Devir = c.Double(),
                        burDifuzyonKule2Akim = c.Double(),
                        burKiyim1Tonaj = c.Double(),
                        burKiyim2Tonaj = c.Double(),
                        burHaslama1sev = c.Double(),
                        burHaslama2sev = c.Double(),
                        tarih = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.burdurscada");
        }
    }
}
