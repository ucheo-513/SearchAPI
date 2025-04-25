using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace PartSearchAPI.Repository
{
    public class PartDBContext : DbContext
    {
        
        
        public PartDBContext(DbContextOptions<PartDBContext> options) : base(options)
        {            
        }

        public DbSet<Database_Model.Part> Parts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database_Model.Part>()
                .Property(p => p.Status);
                
        }
    }    
}
