﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookPlaceholder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public double Rating { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public string Language { get; set; }
    }
}
