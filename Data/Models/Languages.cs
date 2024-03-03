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
        public int Languages_id { get; set; }
        [Required]
        public string Languages_code { get; set; }
        [Required]
        public int Languages_name { get; set; }
    }
}
