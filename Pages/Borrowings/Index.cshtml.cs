using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Strimbei_Maria_Laborator2._1.Data;
using Strimbei_Maria_Laborator2._1.Models;

namespace Strimbei_Maria_Laborator2._1.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context _context;

        public IndexModel(Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .ThenInclude(b => b.Authors)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}
