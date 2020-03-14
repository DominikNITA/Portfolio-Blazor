using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class ProjectsContainer
    {
        private List<Project> _projects;
        public List<Project> Projects { get => _projects; }
        public ProjectsContainer()
        {
            _projects = new List<Project>();
            createProjects();
        }

        void createProjects()
        {
            _projects.Add(
                new Project(
                "Next Fixtures",
                "Lorem ipsum mordeczko",
                "https://next-fixtures.herokuapp.com",
                "https://github.com/DominikNITA/YourMatches",
                "",
                new DateTime(2020, 1, 1))
            );
            _projects.Add(
                new Project(
                    "Portfolio",
                    "Lorem ipsum mordeczko",
                    "https://next-fixtures.herokuapp.com",
                    "https://github.com/DominikNITA/YourMatches",
                    "",
                    new DateTime(2020, 1, 1))
            );
        }
    }
}
