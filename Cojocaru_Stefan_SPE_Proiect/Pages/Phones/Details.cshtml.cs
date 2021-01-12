using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cojocaru_Stefan_SPE_Proiect.Data;
using Cojocaru_Stefan_SPE_Proiect.Models;

namespace Cojocaru_Stefan_SPE_Proiect.Pages.Phones
{
    public class DetailsModel : PageModel
    {
        private readonly Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext _context;

        public DetailsModel(Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext context)
        {
            _context = context;
        }

        public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone = await _context.Phone.FirstOrDefaultAsync(m => m.ID == id);

            if (Phone == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
