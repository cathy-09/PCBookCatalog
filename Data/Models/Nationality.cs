using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Nationality
    {
        [Key]
        public int NationalityId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { set { Books = value; } }
        public ICollection<Author> Authors { set { Authors = value; } }
    }
}
