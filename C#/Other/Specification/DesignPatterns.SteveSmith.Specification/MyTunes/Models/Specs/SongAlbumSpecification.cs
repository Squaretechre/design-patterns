using System;
using System.Linq.Expressions;
using DesignPatterns.SteveSmith.Specification.MyTunes.Interfaces;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Models.Specs
{
    public class SongAlbumSpecification : ISpecification<Song>
    {
        public int AlbumId { get; set; }

        public SongAlbumSpecification(int albumId)
        {
            AlbumId = albumId;
        }

        public Expression<Func<Song, bool>> Criteria
        {
            get { return s => s.AlbumId == AlbumId; }
        }
    }
}