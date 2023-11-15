using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Strimbei_Maria_Laborator2._1.Models;

namespace Strimbei_Maria_Laborator2._1.Data
{
    public class Strimbei_Maria_Laborator2_1Context : DbContext
    {
        public Strimbei_Maria_Laborator2_1Context (DbContextOptions<Strimbei_Maria_Laborator2_1Context> options)
            : base(options)
        {
        }

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Book> Book { get; set; } = default!;

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Publisher>? Publisher { get; set; }

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Author>? Authors { get; set; }

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Category>? Category { get; set; }

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Member>? Member { get; set; }

        public DbSet<Strimbei_Maria_Laborator2._1.Models.Borrowing>? Borrowing { get; set; }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorID) // Foreign key property in Book entity
                .OnDelete(DeleteBehavior.SetNull);

            // Other configurations if any

            base.OnModelCreating(modelBuilder);
        } */
    }
}
