namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEregliScadaTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.eregliscada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Eregstandartdeposeviye = c.Double(),
                        Eregortadeposeviye = c.Double(),
                        Eregkristalyesildeposeviye = c.Double(),
                        Eregkristalbeyazdeposeviye = c.Double(),
                        EregA1seviye = c.Double(),
                        EregA1Bx = c.Double(),
                        EregA2seviye = c.Double(),
                        EregA2Bx = c.Double(),
                        EregA3seviye = c.Double(),
                        EregA3Bx = c.Double(),
                        EregA4seviye = c.Double(),
                        EregA4Bx = c.Double(),
                        EregA5seviye = c.Double(),
                        EregA5Bx = c.Double(),
                        EregA6seviye = c.Double(),
                        EregA6Bx = c.Double(),
                        EregA7seviye = c.Double(),
                        EregA7Bx = c.Double(),
                        EregA8seviye = c.Double(),
                        EregA8Bx = c.Double(),
                        EregA9seviye = c.Double(),
                        EregA9Bx = c.Double(),
                        EregAB10seviye = c.Double(),
                        EregAB10Bx = c.Double(),
                        EregB1seviye = c.Double(),
                        EregB1Bx = c.Double(),
                        EregB2seviye = c.Double(),
                        EregB2Bx = c.Double(),
                        EregB3seviye = c.Double(),
                        EregB3Bx = c.Double(),
                        EregB4seviye = c.Double(),
                        EregB4Bx = c.Double(),
                        EregB5seviye = c.Double(),
                        EregB5Bx = c.Double(),
                        EregC1seviye = c.Double(),
                        EregC1Bx = c.Double(),
                        EregC2seviye = c.Double(),
                        EregC2Bx = c.Double(),
                        EregC3seviye = c.Double(),
                        EregC3Bx = c.Double(),
                        EregC4seviye = c.Double(),
                        EregC4Bx = c.Double(),
                        EregC5seviye = c.Double(),
                        EregC5Bx = c.Double(),
                        EregC6seviye = c.Double(),
                        EregC6Bx = c.Double(),
                        EregDifuzyonKule1sev = c.Double(),
                        EregDifuzyonKule1Devir = c.Double(),
                        EregDifuzyonKule1Akim = c.Double(),
                        EregDifuzyonKule2sev = c.Double(),
                        EregDifuzyonKule2Devir = c.Double(),
                        EregDifuzyonKule2Akim = c.Double(),
                        EregKiyim1Tonaj = c.Double(),
                        EregKiyim2Tonaj = c.Double(),
                        EregHaslama1sev = c.Double(),
                        EregHaslama2sev = c.Double(),
                        tarih = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.eregliscada");
        }
    }
}
