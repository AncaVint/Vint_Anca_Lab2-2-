using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vint_Anca_Lab2_2_.Data;
using Vint_Anca_Lab2_2_.Models;

namespace Vint_Anca_Lab2_2_.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context _context;

        public DetailsModel(Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {

                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;

            }
            return Page();
        }


    }
}
