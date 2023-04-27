using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Test_Scaffold
{
    public class BD_Cont_Bancar
    {
        [Key]
        [StringLength(34, ErrorMessage = "IBAN trebuie sa aiba 34 dde caractere")]
        [RegularExpression(@"(.{34})")]
        public string IBAN { get; set; }

        [ForeignKey("BD_Student")]
        public BD_Student? CNP { get; set; }

        [StringLength(11, ErrorMessage = "Limita de 11 caractere")]
        public string? contap { get; set; }

        public DateTime? data_em { get; set; }
        public DateTime? data_op { get; set; }

    }
}
