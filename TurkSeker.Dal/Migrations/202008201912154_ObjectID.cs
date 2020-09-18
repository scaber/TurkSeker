namespace TurkSeker.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ObjectID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.genelmd", "ObjectId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.genelmd", "ObjectId");
        }
    }
}
