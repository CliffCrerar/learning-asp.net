using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore;
namespace ContosoUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        int pageSize = 3;

        public string Title = "Students";

        private readonly ContosoUniversity.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public string DateSortArrow { get; set; }
        public string NameSortArrow { get; set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Student> Students { get; set; }

        //public IList<Student> Students { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {
            NameSortArrow = "unsorted";

            DateSortArrow = "unsorted";

            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Student> studentsIQ = from s in _context.Students select s;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.LastName.Contains(searchString) || s.FirstMidName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.LastName);
                    NameSortArrow = "des";
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.EnrollmentDate);
                    DateSortArrow = "asc";
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.EnrollmentDate);
                    DateSortArrow = "des";
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.LastName);
                    NameSortArrow = "asc";
                    break;
            }

            Students = await PaginatedList<Student>.CreateAsync(studentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
            //Students = await studentsIQ.AsNoTracking().ToListAsync();
        }


        public object SortArrowDisplay(string displayParam)
        {
            if (displayParam == "asc")
            {
                return "<i class='fas fa-arrow-up'></i>";
            }
            else if (displayParam == "des")
            {
                return "<i class='fas fa-arrow-down'></i>";
            }
            else
            {
                return "<i class='no-arrow'></i>";
            }
        }
    }
}
