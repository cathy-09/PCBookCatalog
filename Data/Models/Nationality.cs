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
        public Nationality()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int NationalityId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
        //public Author Author { get; set; }
    }
}
