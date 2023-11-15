using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Strimbei_Maria_Laborator2._1.Data;
using Strimbei_Maria_Laborator2._1.Models;

namespace Strimbei_Maria_Laborator2._1.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context _context;

        public CreateModel(Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context context)
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
