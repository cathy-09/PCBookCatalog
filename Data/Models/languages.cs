using System.ComponentModel.DataAnnotations;
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
