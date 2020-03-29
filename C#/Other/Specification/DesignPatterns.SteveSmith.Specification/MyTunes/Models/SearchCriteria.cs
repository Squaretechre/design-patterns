using System.Collections.Generic;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Models
{
    internal class SearchCriteria
    {
        public string SongTitleFilter { get; set; }
        public int MinimumRating { get; set; }
        public List<int> SelectedGenres { get; set; }
        public List<string> SelectedArtists { get; set; }
    }
}