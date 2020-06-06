using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.View
{
    public class Link
    {
        public string LinkId { get; set; }

        public string LinkHref { get; set; }

        public string LinkTitle { get; set; }

        public Link(string id,string title, string href)
        {
            this.LinkId = id;

            this.LinkTitle = title;

            this.LinkHref = href;
        }
    }

    public class NavLinks
    {
        public List<Link> Links = new List<Link>();

        public NavLinks()
        {
            Links.Add(new Link("tab-Home","Home", "/Index"));

            //Links.Add(new Link("tab-About","About", "/About"));

            Links.Add(new Link("tab-Students","Students", "/Students/Index"));

            Links.Add(new Link("tab-Courses","Courses", "/Courses/Index"));

            Links.Add(new Link("tab-Instructors","Instructors", "/Instructors/Index"));

            Links.Add(new Link("tab-Departments","Departments", "/Departments/Index"));
        }
    }
}
