using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string BookName { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public double BookRating { get; set; }
        public int BookPages { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
