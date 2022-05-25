using Microsoft.EntityFrameworkCore;
using SamuraiDomain;
using System;

namespace SamuraiData
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDb; Initial Catalog=SamuraiAppSolution");
        }


       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>()
                .HasMany(s => s.Battles)
                .WithMany(b => b.Samurais)
                .UsingEntity<BattleSamurai>(bs => bs.HasOne<Battle>().WithMany(),
                 bs => bs.HasOne<Samurai>().WithMany()).Property(bs => bs.DateJoined)
                 .HasDefaultValueSql("getdate()");


        }

        //ModelBuilder and all the method called is just used to make EfCore aare of
        // the Many-TOmANY relartiosnhip and the PayLoaf
        // check methosd and underatand
    } 
      
    // we set the SamurailData project as our startup project for Migration to work..
    // How to create Migration is different in .net5.0 and .Net 3.1
}
