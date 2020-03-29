using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Infrastructure
{
    internal static class DbContextFactory
    {
        public static AppDbContext CreateDbContext()
        {
            var dbContext = new AppDbContext();
            dbContext.Database.OpenConnection();
            dbContext.Database.EnsureCreated();
            SeedData(dbContext);
            return dbContext;
        }

        private static void SeedData(AppDbContext dbContext)
        {
            var sampleData = new SampleData();

            foreach (var genre in sampleData.Genres)
            {
                dbContext.Genres.Add(genre);
            }

            foreach (var song in sampleData.Songs)
            {
                dbContext.Songs.Add(song);
            }

            foreach (var album in sampleData.Albums)
            {
                dbContext.Albums.Add(album);
            }

            dbContext.SaveChanges();
        }
    }
}