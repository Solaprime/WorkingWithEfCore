using Microsoft.EntityFrameworkCore;
using SamuraiDomain;
using System;

namespace SamuraiData
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDb; Initial Catalog=SamuraiAppData");
        }
    }
      
    
}
