using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TurkSeker.Dal.Db;

namespace TurkSeker.Dal
{
    public class ModelTurkSeker : IdentityDbContext<Kullanici>
    {
        public ModelTurkSeker() : base("name=ModelTurkSeker")
        {
            Database.SetInitializer<ModelTurkSeker>(new CreateDatabaseIfNotExists<ModelTurkSeker>());
        }   
        public virtual DbSet<genelmd> GenelMd { get; set; }
        public virtual DbSet<Fabrika> Fabrikas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelTurkSeker, Configuration>()); 
            base.OnModelCreating(modelBuilder);
        }


    }

}
