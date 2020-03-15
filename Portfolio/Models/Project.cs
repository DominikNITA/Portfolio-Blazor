using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DemoLink { get; set; }
        public string CodeLink { get; set; }
        public string ImageSource { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Technology> Technologies { get; set; }
        public enum Technology { Csharp, Cplusplus, C, Java, Python, HTML, JavaScript, React, Vue, CSS,
                                Bootstrap, Sass, SQL, Heroku, Postgresql, Linux, Windows, Android};

        public Project(string name, string description, string demoLink, string codeLink, string imageSource, DateTime creationDate, List<Technology> technologies)
        {
            Name = name;
            Description = description;
            DemoLink = demoLink;
            CodeLink = codeLink;
            ImageSource = imageSource;
            CreationDate = creationDate;
            Technologies = technologies;
        }
    }
}
