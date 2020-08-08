using System.Data.Entity;
using TurkSeker.Dal.Db;

namespace TurkSeker.Dal
{
    public class ModelTurkSeker : DbContext
    {
        public ModelTurkSeker():base("name=ModelTurkSeker")
        {

        } 
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<genelmd> GenelMd { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

          //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelTurkSeker, Configuration>()); 
            base.OnModelCreating(modelBuilder);
        }

    }

}
