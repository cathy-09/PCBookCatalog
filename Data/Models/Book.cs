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
        private int genreId;
        public int GenreId { set { genreId = value; } }
        private int authorId;
        public int AuthorId { set { authorId = value; } }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        private int publisherId;
        public int PublisherId { set { publisherId = value; } }
        public Publisher Publisher { get; set; }
        public double Rating { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        private int languageId;
        public int LanguageId { set { languageId = value; } }
        public Language Language { get; set; }
        //public BookAuthor BookAuthor { get; set; }
        public ICollection<BookAuthor> BookAuthors { set { BookAuthors = value; } }
    }
}
