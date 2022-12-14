using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fat_Delia_Lab2.Data;
using Fat_Delia_Lab2.Models;

namespace Fat_Delia_Lab2.Pages.Publisher
{
    public class CreateModel : PageModel
    {
        private readonly Fat_Delia_Lab2.Data.Fat_Delia_Lab2Context _context;

        public CreateModel(Fat_Delia_Lab2.Data.Fat_Delia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
