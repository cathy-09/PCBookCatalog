using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Genres
    {        
        [Key]
        public int  GenresId { get; set; }
        [Required]
        public string GenresName { get; set; }

        //Mateo zdr ICollection Book
    }
}
