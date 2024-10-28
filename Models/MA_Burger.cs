﻿using System.ComponentModel.DataAnnotations;

namespace MellArguello_EXAMENP1.Models
{
    public class MA_Burger
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
    }
}
