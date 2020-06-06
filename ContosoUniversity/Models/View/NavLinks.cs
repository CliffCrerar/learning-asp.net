using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.View
{
    public class Link
    {
        public string LinkHref { get; set; }

        public string LinkTitle { get; set; }

        public Link(string title, string href)
        {
            this.LinkTitle = title;

            this.LinkHref = href;
        }
    }

    public class NavLinks
    {
        public List<Link> Links = new List<Link>();

        public NavLinks()
        {
            Links.Add(new Link("About", "/About"));

            Links.Add(new Link("Students", "/Students/Index"));

            Links.Add(new Link("Courses", "/Courses/Index"));

            Links.Add(new Link("Instructor", "/Instructor/Index"));

            Links.Add(new Link("Departments", "/Departments/Index"));

           
        }
    }
}
