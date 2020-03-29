using DesignPatterns.SteveSmith.Specification.MyTunes.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=:memory:");
    }
}
