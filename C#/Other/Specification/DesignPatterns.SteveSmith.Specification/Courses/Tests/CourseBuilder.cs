using System;
using System.Collections.Generic;
using DesignPatterns.SteveSmith.Specification.Courses.Models;

namespace DesignPatterns.SteveSmith.Specification.Courses.Tests
{
    public class CourseBuilder
    {
        private List<Module> _modules;
        private List<AuthorContract> _authorContracts;
        private DateTime _publicationDate;
        private string _description;

        public CourseBuilder ACourseReadyToPublish()
        {
            var atLeastOneModuleWithSlidesAndMaterials = new List<Module>
            {
                new Module
                {
                    SlideUrl = "http://pluralsight.com/slides",
                    MaterialsUrl = "http://pluralsight.com/materials",
                }
            };

            var atLeastOneSignedAuthorContract = new List<AuthorContract>
            {
                new AuthorContract
                {
                    Signed = true,
                }
            };

            var aNonNullPublicationDate = new DateTime(2025, 12, 01);
            var aPopulatedDescription = "Lorem ipsum.";

            _modules = atLeastOneModuleWithSlidesAndMaterials;
            _authorContracts = atLeastOneSignedAuthorContract;
            _publicationDate = aNonNullPublicationDate;
            _description = aPopulatedDescription;

            return this;
        }

        public CourseBuilder Description(string description)
        {
            _description = description;
            return this;
        }

        public CourseBuilder Modules(List<Module> modules)
        {
            _modules = modules;
            return this;
        }

        public CourseBuilder AuthorContracts(List<AuthorContract> authorContracts)
        {
            _authorContracts = authorContracts;
            return this;
        }

        public CourseBuilder With()
        {
            return this;
        }

        public Course Build()
        {
            return new Course
            {
                Modules = _modules,
                AuthorContracts = _authorContracts,
                PublicationDate = _publicationDate,
                Description = _description,
            };
        }
    }
}