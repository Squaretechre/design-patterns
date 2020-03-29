using System;
using System.Linq.Expressions;
using DesignPatterns.SteveSmith.Specification.MyTunes.Interfaces;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Models.Specs
{
    public class SongYearSpecification : ISpecification<Song>
    {
        public int Year { get; set; }

        public SongYearSpecification(int year)
        {
            Year = year;
        }

        public Expression<Func<Song, bool>> Criteria
        {
            get { return s => s.Year == Year; }
        }
    }
}