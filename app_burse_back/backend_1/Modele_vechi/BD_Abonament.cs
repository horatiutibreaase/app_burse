using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Test_Scaffold
{
    public class BD_Abonament
    {
        [Key]
        public int cod_abo { get; set; }

        [ForeignKey("BD_Student")]
        public BD_Student? CNP { get; set; }

        [Range(1, 12)]
        public int? luna { get; set; }
        public byte? platit { get; set; }
        public DateTime? data_plati { get; set; }
        public DateTime? data_in { get; set; }
        public DateTime? data_op { get; set; }

    }
}
