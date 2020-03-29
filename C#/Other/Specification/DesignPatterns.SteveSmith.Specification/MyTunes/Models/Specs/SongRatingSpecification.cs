using System;
using System.Linq.Expressions;
using DesignPatterns.SteveSmith.Specification.MyTunes.Interfaces;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Models.Specs
{
    public class SongRatingSpecification : ISpecification<Song>
    {
        public int MinRating { get; set; }

        public SongRatingSpecification(int minRating)
        {
            MinRating = minRating;
        }

        public Expression<Func<Song, bool>> Criteria
        {
            get { return s => s.Rating >= MinRating; }
        }
    }
}