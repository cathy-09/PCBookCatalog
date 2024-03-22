using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Publisher
    {
        public Publisher()
        {

        }
        public Publisher(string name)
        {
            this.PublisherName = name;
        }
        [Key]
        public int PublisherId { get; set; }
        [Required]
        public string PublisherName { get; set; }

        public ICollection<Book> Books { set { Books = value; } }
    }
}
