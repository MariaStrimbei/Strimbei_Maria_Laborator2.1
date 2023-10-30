using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Strimbei_Maria_Laborator2._1.Data;
using Strimbei_Maria_Laborator2._1.Models;

namespace Strimbei_Maria_Laborator2._1.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context _context;

        public IndexModel(Strimbei_Maria_Laborator2._1.Data.Strimbei_Maria_Laborator2_1Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public SelectList Authors { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AuthorFilter { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> authorQuery = from b in _context.Book
                                             orderby b.Author.LastName, b.Author.FirstName
                                             select $"{b.Author.FirstName} {b.Author.LastName}";


            Authors = new SelectList(await authorQuery.Distinct().ToListAsync());

            var books = from b in _context.Book
                        select b;

            if (!string.IsNullOrEmpty(AuthorFilter))
            {
                books = books.Where(b => b.Author.LastName == AuthorFilter);
            }

            Book = await _context.Book
    .Include(b => b.Publisher)
    .ToListAsync();
            }
        }
    }
