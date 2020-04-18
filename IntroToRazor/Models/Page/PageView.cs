using System;
using System.Collections.Generic;

namespace IntroToRazor.Models.Page
{
    // For navlinks
    public class Link
    {
        public string Caption { get; set; }

        public string Href { get; set; }

        public string Title { get; set; }

        public Link(string caption, string href, string title)
        {
            Caption = caption;
            Href = href;
            Title = Title;
        }
    }
    // navbar brand
    public class Brand
    {
        public string Caption { get; set; }

        public string Href { get; set; }

        public Brand(string caption, string href)
        {
            Caption = caption;
            Href = href;
        }

    }
    // List of links
    public class NavLinks
    {
        public List<Link> Links { get; set; }

        public NavLinks()
        {
            Links = new List<Link>();
        }
    }
    // the footer
    public class Footer
    {

        public string Caption { get; set; }

        public Link Link { get; set; }

        public Footer(string caption, Link link)
        {
            Caption = caption;
            Link = link;
        }
    }
    // the general layout
    public class Layout
    {
        public Brand Brand { get; set; }

        public List<Link> NavLinks { get; set; }

        public Footer Footer { get; set; }
    }
}
