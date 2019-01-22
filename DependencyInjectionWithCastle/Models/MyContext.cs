using System.Data.Entity;

namespace DependencyInjectionWithCastle.Models
{
    public class MyContext :DbContext
    {
        public MyContext() :base ("MyConnectionString")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;
        }
        public DbSet<IranGravity> IranGravity { get; set; }


    }
}