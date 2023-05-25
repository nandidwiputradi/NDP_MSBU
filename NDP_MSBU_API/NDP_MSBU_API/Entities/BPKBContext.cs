using Microsoft.EntityFrameworkCore;

namespace NDP_MSBU_API.Entities
{  
    public class BPKBContext : DbContext
    {
        public DbSet<StorageLocationEntities> storageLocationEntities { get; set; }
        public DbSet<BPKBEntities> bpkbEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
