using System;
using System.ComponentModel.DataAnnotations;

namespace staj_deneme1.Models
{
    public class sefer
    {
        public int Id { get; set; }

        [Required]
        public string SeferNo { get; set; }

        [Required]
        public string Kalkis { get; set; }

        [Required]
        public string Varis { get; set; }

        [Required]
        public DateTime TarihSaat { get; set; }
    }
}




