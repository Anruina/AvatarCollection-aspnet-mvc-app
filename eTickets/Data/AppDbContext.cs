using AvatarCollections.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace AvatarCollections.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
              
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define FK
            modelBuilder.Entity<Actor_Collectable>().HasKey(am => new
            {
                am.ActorID,
                am.CollectableID
            });

            modelBuilder.Entity<Actor_Collectable>().HasOne(m => m.Collectable).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.CollectableID);
            modelBuilder.Entity<Actor_Collectable>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorID);

            base.OnModelCreating(modelBuilder);
        }

        //table names
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Collectable> Collectables { get; set; }
        public DbSet<Actor_Collectable> Actors_Collectables { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
