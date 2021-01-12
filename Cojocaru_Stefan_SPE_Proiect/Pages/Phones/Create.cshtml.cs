using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cojocaru_Stefan_SPE_Proiect.Data;
using Cojocaru_Stefan_SPE_Proiect.Models;

namespace Cojocaru_Stefan_SPE_Proiect.Pages.Phones
{
    public class CreateModel : PageModel
    {
        private readonly Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext _context;

        public CreateModel(Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Phone Phone { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Phone.Add(Phone);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
