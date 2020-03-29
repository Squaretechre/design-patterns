using System.Linq;
using DesignPatterns.SteveSmith.Specification.Courses.Interfaces;
using DesignPatterns.SteveSmith.Specification.Courses.Models;
using static System.String;

namespace DesignPatterns.SteveSmith.Specification.Courses
{
    public class CourseReadyToPublishSpecification : ISpecification<Course>
    {
        public bool IsSatisfiedBy(Course course)
        {
            if (IsNullOrEmpty(course.Description)) return false;
            if (!course.PublicationDate.HasValue) return false;
            if (!course.Modules.Any()) return false;
            if (course.Modules.Any(m => IsNullOrEmpty(m.SlideUrl))) return false;
            if (course.Modules.Any(m => IsNullOrEmpty(m.MaterialsUrl))) return false;
            if (!course.AuthorContracts.Any()) return false;
            if (course.AuthorContracts.Any(c => !c.Signed)) return false;
            return true;
        }
    }
}
