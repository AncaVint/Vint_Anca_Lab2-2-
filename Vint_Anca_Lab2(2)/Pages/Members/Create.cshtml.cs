﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vint_Anca_Lab2_2_.Data;
using Vint_Anca_Lab2_2_.Models;

namespace Vint_Anca_Lab2_2_.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context _context;

        public CreateModel(Vint_Anca_Lab2_2_.Data.Vint_Anca_Lab2_2_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Member == null || Member == null)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
