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
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }
        public double Rating { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public Language Language { get; set; }
        public ICollection<BookAuthor> BookAuthors { set { BookAuthors = value; } }
    }
}
