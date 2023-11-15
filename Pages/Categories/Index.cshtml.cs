using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Strimbei_Maria_Laborator2._1.Data;
using Strimbei_Maria_Laborator2._1.Models;
using Strimbei_Maria_Laborator2._1.Models.ViewModels;

namespace Strimbei_Maria_Laborator2._1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context _context;

        public IndexModel(Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context context)
        {
            _context = context;
        }


public IList<Book> Book { get; set; } = default!;

public async Task OnGetAsync()
{
    if (_context.Book != null)
    {
        Book = await _context.Book
            .Include(b => b.Publisher).Include(b => b.Authors)
            .ToListAsync();
    }
}
    }
}