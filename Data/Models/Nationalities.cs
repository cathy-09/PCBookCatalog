using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Nationalities
    {
        [Key]
        public int NationalityId { get; set; }

        [Required]
        public string NationalityName { get; set; }
        public ICollection<Authors> Authors { get; set; }
    }
}
