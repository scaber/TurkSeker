using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkSeker.Dal.Db;

namespace TurkSeker.Dal
{
    public class ModelTurkSeker : DbContext
    {
        public ModelTurkSeker():base("name=ModelTurkSeker")
        {

        }

        public virtual DbSet<Kullanici> Kullanici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

          //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelTurkSeker, Configuration>()); 
            base.OnModelCreating(modelBuilder);
        }

    }

}
