using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cojocaru_Stefan_SPE_Proiect.Models;

namespace Cojocaru_Stefan_SPE_Proiect.Data
{
    public class Cojocaru_Stefan_SPE_ProiectContext : DbContext
    {
        public Cojocaru_Stefan_SPE_ProiectContext (DbContextOptions<Cojocaru_Stefan_SPE_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Cojocaru_Stefan_SPE_Proiect.Models.Phone> Phone { get; set; }
    }
}
