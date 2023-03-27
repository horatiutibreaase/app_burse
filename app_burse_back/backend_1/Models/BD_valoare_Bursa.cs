using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Models
{
    public class BD_valoare_Bursa
    {
        public int? id_bursa { get; set; }

        [ForeignKey("BD_bursa_Denumire")]
        public BD_bursa_Denumire? denumire_bursa { get; set; }

        [RegularExpression((@"^\d+(\.\d{1,2})?$"))]
        [Range(0, 99999999.99)]
        public decimal? cuantum_bursa { get; set; }
    }
}
