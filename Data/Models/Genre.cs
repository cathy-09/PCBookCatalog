using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Genre
    {
        public Genre()
        {

        }
        public Genre(string name)
        {
            this.GenreName = name;
        }

        [Key]
        public int  GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }

        public ICollection<Book> Books { set { Books = value; } }
    }
}
