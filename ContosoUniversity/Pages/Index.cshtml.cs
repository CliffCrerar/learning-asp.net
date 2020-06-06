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
        public string PageHeading { get; } = "Tos Rond Universiteit";

        [ViewData]
        public string PageSubtitle { get; } = "ASP.NET Core and Entity Framework Core with SQL Server Demo Application";

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
