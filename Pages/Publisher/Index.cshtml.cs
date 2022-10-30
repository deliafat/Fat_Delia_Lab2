using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fat_Delia_Lab2.Data;
using Fat_Delia_Lab2.Models;

namespace Fat_Delia_Lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Fat_Delia_Lab2.Data.Fat_Delia_Lab2Context _context;

        public IndexModel(Fat_Delia_Lab2.Data.Fat_Delia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
