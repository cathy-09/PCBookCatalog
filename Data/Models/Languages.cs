using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data.Models
{
    public class languages
    {
        [Key]
        public int Lnguages_id { get; set; }
        [Required]
        public string Languages_code { get; set; }
        [Required]
        public int Lnguages_name { get; set; }
    }
}
