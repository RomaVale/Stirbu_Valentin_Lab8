using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stirbu_Valentin_Lab8.Models;
using Microsoft.EntityFrameworkCore;

namespace Stirbu_Valentin_Lab8.Data
{
    public class Stirbu_Valentin_Lab8Context : DbContext
    {
        public Stirbu_Valentin_Lab8Context (DbContextOptions<Stirbu_Valentin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stirbu_Valentin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Stirbu_Valentin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Stirbu_Valentin_Lab8.Models.Category> Category { get; set; }
    }
}
