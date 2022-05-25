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
                "Data Source=(localdb)\\MSSQLLocalDb; Initial Catalog=SamuraiAppSolution");
        }
    }
      
    // we set the SamurailData project as our startup project for Migration to work..
    // How to create Migration is different in .net5.0 and .Net 3.1
}
