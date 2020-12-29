namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class suleymaneditgenelmd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.genelmd", "Kayit_tar_saat", c => c.DateTime());
            DropColumn("dbo.genelmd", "ObjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.genelmd", "ObjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.genelmd", "Kayit_tar_saat", c => c.DateTime(nullable: false));
        }
    }
}
