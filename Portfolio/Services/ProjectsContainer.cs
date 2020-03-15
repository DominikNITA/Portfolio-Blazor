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
            CreateProjects();
        }

        void CreateProjects()
        {
            _projects.Add(
                new Project(
                "Next Fixtures",
                "Lorem ipsum mordeczko",
                "https://next-fixtures.herokuapp.com",
                "https://github.com/DominikNITA/YourMatches",
                "https://i.ibb.co/wScsFyv/Next-Fixtures.png",
                new DateTime(2020, 1, 1),
                new List<Project.Technology> { Project.Technology.Csharp, Project.Technology.Bootstrap }
            ));
            _projects.Add(
                new Project(
                    "Portfolio",
                    "Lorem ipsum mordeczko",
                    "https://next-fixtures.herokuapp.com",
                    "https://github.com/DominikNITA/Portfolio-Blazor",
                    "https://i.ibb.co/rsJQ0BD/Portfolio.png",
                    new DateTime(2020, 1, 1),
                    new List<Project.Technology> { Project.Technology.Csharp, Project.Technology.Sass }
                    ));
            _projects.Add(
    new Project(
        "BlazorThemeSwitcher",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/BlazorThemeSwitcher",
        "https://i.ibb.co/fDzGb1r/Blazor-Theme.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.Csharp, Project.Technology.CSS }
        ));
            _projects.Add(
    new Project(
        "UDP & TCP",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/YourMatches",
        "https://i.ibb.co/6nMbjd1/TCP-UDP.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.C, Project.Technology.Linux }
        ));
            _projects.Add(
    new Project(
        "File Compression",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/YourMatches",
        "https://i.ibb.co/qDH3mJb/download.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.Cplusplus }
        ));
            _projects.Add(
    new Project(
        "Gentrification Simulation",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/Gentrification",
        "https://i.ibb.co/nszPBPX/endow.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.Python }
        ));
            _projects.Add(
    new Project(
        "Evacuation Simulation",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/EvacuationSimulation",
        "https://i.ibb.co/8cSVmGn/Evacuation.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.Java }
        ));
            _projects.Add(
    new Project(
        "Text To Dots",
        "Lorem ipsum mordeczko",
        "",
        "https://github.com/DominikNITA/TextToDots",
        "https://i.ibb.co/XsyZ900/Text-To-Dot.png",
        new DateTime(2020, 1, 1),
        new List<Project.Technology> { Project.Technology.JavaScript, Project.Technology.HTML, Project.Technology.CSS }
        ));
        }
    }
}
