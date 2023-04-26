using System.ComponentModel.DataAnnotations;

namespace backend_1.Test_Scaffold
{
    public class BD_Facultate
    {
        [Key]
        public int id_facultate { get; set; }

        [StringLength(70, ErrorMessage = "Limita de 70 de caractere")]//lungime maxima de 70 caractere pt ca in baza de date e varchar(70)
        public string? denumire_facultate { get; set; }
    }
}
