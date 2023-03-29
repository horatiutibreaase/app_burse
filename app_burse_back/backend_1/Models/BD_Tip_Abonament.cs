using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Models
{
    public class BD_Tip_Abonament
    {
        [ForeignKey("BD_Abonament")]
        public BD_Abonament? cod_abo { get; set; }

        [StringLength(20,ErrorMessage ="Limita de 20 de caractere")]
        public string? denumire_abonament { get; set; }

        [RegularExpression((@"^\d+(\.\d{1,2})?$"))]
        [Range(0, 99999999.99)]
        public decimal? cuantum_abonament { get; set; }
    }
}
