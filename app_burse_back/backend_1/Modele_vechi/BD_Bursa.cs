using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Test_Scaffold
{
    public class BD_Bursa
    {
        [ForeignKey("BD_Student")]
        public BD_Student? CNP { get; set; }

        [Required]
        public int id_bursa { get; set; }

        [StringLength(20, ErrorMessage = "Limita de 20 de caractere")]
        public string? semestru { get; set; }

        public DateTime? data_plati { get; set; }

        public byte? platit { get; set; }

        public int? zile_plati { get; set; }

        public int? cod_bursa { get; set; }
    }
}
