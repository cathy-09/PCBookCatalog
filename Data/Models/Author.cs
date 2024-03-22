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
        public Author()
        {

        }
        public Author(string name, int id)
        {
            this.Name = name;
            this.NationalityId = id;
        }

        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public ICollection<Book> Books { set { Books = value; } }
        public ICollection<BookAuthor> BookAuthors { set { BookAuthors = value; } }
    }
}
