using System.ComponentModel.DataAnnotations;
namespace Data.Models
{
    public class Genres
    {        
        [Key]
        public int  Genres_id { get; set; }
        [Required]
        public string Genres_name { get; set; }
    }
}
