﻿using System.ComponentModel.DataAnnotations;

namespace backend_1.Models
{
    public class BD_bursa_Denumire
    {
        [Key]
        [StringLength(150,ErrorMessage ="Limita de 150 de caractere")]
        public string denumire_bursa { get; set; }
    }
}
