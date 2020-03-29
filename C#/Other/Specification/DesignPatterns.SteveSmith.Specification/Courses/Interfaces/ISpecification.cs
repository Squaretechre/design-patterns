namespace DesignPatterns.SteveSmith.Specification.Courses.Interfaces
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T target);
    }
}