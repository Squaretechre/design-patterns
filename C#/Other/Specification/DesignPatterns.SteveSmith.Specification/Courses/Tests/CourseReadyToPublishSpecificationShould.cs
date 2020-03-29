using System.Collections.Generic;
using DesignPatterns.SteveSmith.Specification.Courses.Models;
using Xunit;

namespace DesignPatterns.SteveSmith.Specification.Courses.Tests
{
    public class CourseReadyToPublishSpecificationShould
    {
        private readonly CourseReadyToPublishSpecification _sut;

        public CourseReadyToPublishSpecificationShould()
        {
            _sut = new CourseReadyToPublishSpecification();
        }

        [Fact]
        public void be_satisfied_when_course_meets_specification()
        {
            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .Build();

            Assert.True(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_description_is_null()
        {
            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .Description(null)
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_description_is_empty()
        {
            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .Description(string.Empty)
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_course_does_not_have_any_modules()
        {
            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .Modules(new List<Module>())
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_course_has_modules_but_any_are_missing_their_slide_url()
        {
            var modules = new List<Module>
            {
                new Module { MaterialsUrl = "https://materials/", SlideUrl = "https://slides/" },
                new Module { MaterialsUrl = "https://materials/", SlideUrl = string.Empty },
                new Module { MaterialsUrl = "https://materials/", SlideUrl = "https://slides/" },
            };

            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .Modules(modules)
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_course_has_modules_but_any_are_missing_their_materials_url()
        {
            var modules = new List<Module>
            {
                new Module { MaterialsUrl = "https://materials/", SlideUrl = "https://slides/" },
                new Module { MaterialsUrl = "https://materials/", SlideUrl = "https://slides/" },
                new Module { MaterialsUrl = string.Empty, SlideUrl = "https://slides/" },
            };

            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .Modules(modules)
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_course_does_not_have_any_author_contracts()
        {
            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .AuthorContracts(new List<AuthorContract>())
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }

        [Fact]
        public void not_be_satisfied_when_course_has_author_contracts_but_any_are_not_signed()
        {
            var authorContracts = new List<AuthorContract>
            {
                new AuthorContract {Signed = true},
                new AuthorContract {Signed = false},
            };

            var course = new CourseBuilder()
                .ACourseReadyToPublish()
                .With()
                .AuthorContracts(authorContracts)
                .Build();

            Assert.False(_sut.IsSatisfiedBy(course));
        }
    }
}
