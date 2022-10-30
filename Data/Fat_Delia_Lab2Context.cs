using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fat_Delia_Lab2.Models;

namespace Fat_Delia_Lab2.Data
{
    public class Fat_Delia_Lab2Context : DbContext
    {
        public Fat_Delia_Lab2Context (DbContextOptions<Fat_Delia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Fat_Delia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Fat_Delia_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
