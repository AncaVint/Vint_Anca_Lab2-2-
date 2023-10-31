using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vint_Anca_Lab2_2_.Data;
using Vint_Anca_Lab2_2_.Models;

namespace Vint_Anca_Lab2_2_.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context _context;

        public DetailsModel(Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context context)
        {
            _context = context;
        }

      public Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
