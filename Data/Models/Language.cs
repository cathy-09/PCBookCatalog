using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Language
    {
        public Language()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int LanguageId { get; set; }
        [Required]
        public int LanguageCode { get; set;}
        [Required]
        public string LanguageName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
