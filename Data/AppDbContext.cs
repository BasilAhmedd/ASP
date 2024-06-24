using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie_Actor>().HasKey(x => new { x.MovieId, x.ActorId });
            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.movie).WithMany(x => x.movie_Actors).HasForeignKey(x => x.MovieId);
            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.actor).WithMany(x => x.movie_Actors).HasForeignKey(x => x.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<actor> actors { get; set; }
        public DbSet<cinema> cinemas { get; set; }
        public DbSet<producers> producers { get; set; }
        public DbSet<movie> movies { get; set; }
        public DbSet<Movie_Actor> movie_Actors { get; set; }
    }
}
