using System;
using System.Linq.Expressions;
using DesignPatterns.SteveSmith.Specification.MyTunes.Interfaces;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Models.Specs
{
    public class AllSongsSpecification : ISpecification<Song>
    {
        public Expression<Func<Song, bool>> Criteria { get; } = s => true;
    }
}