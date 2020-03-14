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

        public Project(string name, string description, string demoLink, string codeLink, string imageSource, DateTime creationDate)
        {
            Name = name;
            Description = description;
            DemoLink = demoLink;
            CodeLink = codeLink;
            ImageSource = imageSource;
            CreationDate = creationDate;
        }
    }
}
