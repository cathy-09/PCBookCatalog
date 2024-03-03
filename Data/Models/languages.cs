using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data.Models
{
    public class Languages
    {
        [Key]
        public int LanguagesId { get; set; }
        [Required]
        public string LanguagesCode { get; set; }
        [Required]
        public int LanguagesName { get; set; }

        //Mateo zdr ICollection Book
    }
}
