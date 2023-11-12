using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Vint_Anca_Lab2_2_.Models
{
    public class Book
    {
        public int ID { get; set; }
        
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        
        public int? PublisherID { get; set; }
        [Display(Name = "Publisher Name")]
        public Publisher? Publisher { get; set; }
        
        public int? AuthorID { get; set; }
        [Display(Name = "Author Name")]
        public Author? Author { get; set; }
        
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
