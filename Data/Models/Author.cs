using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public ICollection<BookAuthor> BooksAuthors { get; set; }
    }
}
