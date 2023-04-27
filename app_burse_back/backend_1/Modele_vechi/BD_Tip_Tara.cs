using System.ComponentModel.DataAnnotations;

namespace backend_1.Test_Scaffold
{
    public class BD_Tip_Tara
    {
        [Key]
        [StringLength(20, ErrorMessage = "Limita de 20 de caractere")]
        public string tip_tara { get; set; }
    }
}
