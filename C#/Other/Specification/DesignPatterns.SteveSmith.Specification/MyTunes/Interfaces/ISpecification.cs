using System;
using System.Linq.Expressions;

namespace DesignPatterns.SteveSmith.Specification.MyTunes.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}