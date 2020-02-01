using System.Data.Entity;

namespace Diplomnaya
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("name=MyZakaz")
        { }
        public DbSet<ModelZakaz> Zakazs { get; set; }
        public DbSet<ModelClient> Clients { get; set; }
        public DbSet<ModelWork> Works { get; set; }
        public DbSet<ModelDetail> Details { get; set; }
        public DbSet<ModelCar> Cars { get; set; }
    }
}
