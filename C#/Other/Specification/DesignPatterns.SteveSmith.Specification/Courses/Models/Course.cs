using System;
using System.Collections.Generic;

namespace DesignPatterns.SteveSmith.Specification.Courses.Models
{
    public class Course
    {
        public IEnumerable<Module> Modules { get; set; }
        public IEnumerable<AuthorContract> AuthorContracts { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Description { get; set; }
    }
}
