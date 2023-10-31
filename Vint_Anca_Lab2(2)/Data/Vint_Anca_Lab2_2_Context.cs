using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vint_Anca_Lab2_2_.Models;

namespace Vint_Anca_Lab2_2_.Data
{
    public class Vint_Anca_Lab2_2_Context : DbContext
    {
        public Vint_Anca_Lab2_2_Context (DbContextOptions<Vint_Anca_Lab2_2_Context> options)
            : base(options)
        {
        }

        public DbSet<Vint_Anca_Lab2_2_.Models.Book> Book { get; set; } = default!;

        public DbSet<Vint_Anca_Lab2_2_.Models.Publisher>? Publisher { get; set; }

        public DbSet<Vint_Anca_Lab2_2_.Models.Author>? Author { get; set; }

        public DbSet<Vint_Anca_Lab2_2_.Models.Category>? Category { get; set; }
    }
}
