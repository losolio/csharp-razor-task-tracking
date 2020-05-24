using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _context;
        public IEnumerable<Task> Tasks { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Tasks = _context.Tasks
                .OrderBy(x => x.Priority);

        }
    }
}