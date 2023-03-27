﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Models
{
    public class BD_Specializare
    {
        [Key]
        public int id_specializare { get; set; }

        [StringLength(60,ErrorMessage = "Limita de 70 de caractere")]
        public string? denumire_specializare { get; set; }

        [ForeignKey("BD_Facultate")]
        public BD_Facultate? id_facultate { get; set; }//foreign key, un obiect de tip bd_facultate, schimbi u=numele sau nu?  


    }
}