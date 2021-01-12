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
    public class IndexModel : PageModel
    {
        private readonly Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext _context;

        public IndexModel(Cojocaru_Stefan_SPE_Proiect.Data.Cojocaru_Stefan_SPE_ProiectContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }



       public IList<Phone> Phone { get;set; }
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            // using System;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
            ViewData["CurrentFilter"] = searchString;

            IQueryable<Phone> phonesIQ = from s in _context.Phone
                                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                phonesIQ = phonesIQ.Where(s => s.Brand.Contains(searchString));
                                      
            }

            switch (sortOrder)
            {
                case "name_asc":
                    phonesIQ = phonesIQ.OrderBy(s => s.Brand);
                    break;
                
               
            }

            Phone = await phonesIQ.AsNoTracking().ToListAsync();
        }
        

        /*  public async Task OnGetAsync()
          {
              Phone = await _context.Phone.ToListAsync();
          } */

    }
    
}
