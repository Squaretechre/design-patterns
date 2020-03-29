using System;
using System.Collections.Generic;
using DesignPatterns.SteveSmith.Specification.MyTunes.Infrastructure;
using DesignPatterns.SteveSmith.Specification.MyTunes.Models;
using DesignPatterns.SteveSmith.Specification.MyTunes.Models.Specs;

namespace DesignPatterns.SteveSmith.Specification.MyTunes
{
    internal class Program
    {
        private static void Main()
        {
            var dbContext = DbContextFactory.CreateDbContext();
            var songRepository = new SongRepository(dbContext);

            var searchCriteria = MetallicaAndToolSongsRated5ContainingAnEInTheTitle();

            var specification = new GlobalSongSpecification
            {
                MinRating = searchCriteria.MinimumRating,
                TitleFilter = searchCriteria.SongTitleFilter,
                ArtistsToInclude = searchCriteria.SelectedArtists,
                GenreIdsToInclude = searchCriteria.SelectedGenres,
            };

            var songResults = songRepository.List(specification);
            var allSongs = songRepository.AllSongs();

            PrintResults(songResults);
            PrintAllSongs(allSongs);

            Console.ReadKey();
        }

        private static SearchCriteria MetallicaAndToolSongsRated5ContainingAnEInTheTitle()
        {
            return new SearchCriteria
            {
                SongTitleFilter = "e",
                MinimumRating = 5,
                SelectedGenres = new List<int>(),
                SelectedArtists = new List<string> { "Metallica", "Tool" },
            };
        }

        private static void PrintResults(IEnumerable<Song> songResults)
        {
            Console.WriteLine("Results");
            Console.WriteLine("-------");

            foreach (var song in songResults)
            {
                Console.WriteLine($"{song.Artist} - {song.Title}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("All songs");
            Console.WriteLine("---------");
        }

        private static void PrintAllSongs(IEnumerable<Song> allSongs)
        {
            foreach (var song in allSongs)
            {
                Console.WriteLine($"{song.Artist} - {song.Title}");
            }
        }
    }
}
