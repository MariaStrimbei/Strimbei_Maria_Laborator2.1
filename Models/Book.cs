using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Strimbei_Maria_Laborator2._1.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public int? AuthorsID { get; set; }
        public Author? Authors { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public string BookDetails => $"{Title} - Price: {Price:C} - Published on: {PublishingDate:d}";
    



    public ICollection<BookCategory>? BookCategories { get; set; }

        
       
    }
}
