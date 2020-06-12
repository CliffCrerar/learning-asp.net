using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity.Pages
{
    public class IndexModel : PageModel
    {
        [ViewData]
        public string PageHeading { get; } = ".NET Demo";
        [ViewData]
        public string PageSubtitle { get; } = "ASP.NET Core and Entity Framework Core with SQL Server Demo Application";
        [ViewData]
        public string ProjectUrl { get; } = "https://github.com/CliffCrerar/learning-asp.net/tree/master/ContosoUniversity";
        [ViewData]
        public string ProjectDesc { get; } = "Contoso University is a sample application that demonstrates how to use Entity Framework Core in an ASP.NET Core Razor Pages web app.";
        [ViewData]
        public string ProjectTutorial { get; } = "You can build the application by following the steps in a series of tutorials.";
        [ViewData]
        public string ProjectTutorialLink { get; } = "https://docs.microsoft.com/aspnet/core/data/ef-rp/intro";
        [ViewData]
        public string ProjectTutorialLinkCaption { get; } = "See the tutorial";
        [ViewData]
        public string CompletedProject { get; } = "You can download the completed project from GitHub.";
        [ViewData]
        public string CompletedProjectLink { get; } = "https://github.com/dotnet/AspNetCore.Docs/tree/master/aspnetcore/data/ef-rp/intro/samples";
        [ViewData]
        public string CompletedProjectLinkCaption { get; } = "See project source code";

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }

        public void OnGet()
        {
            _logger.LogInformation(Message);
        }
    }
}
