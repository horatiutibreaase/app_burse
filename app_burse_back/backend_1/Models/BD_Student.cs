using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_1.Models
{
    public class BD_Student
    {
        [Key]
        [StringLength(13,ErrorMessage ="CNP introdus nu are 13 caractere")]//nu fixez cnp la 13 caractere pt ca e posibil sa fie studenti straini cu cnp din alta tara si nu stiu cat de lung e acela
        public string CNP { get; set; }

        [StringLength(50,ErrorMessage ="Limita de 50 caractere")]
        public string? nume { get; set; }

        [ForeignKey("BD_Tip_Tara")]
        //[StringLength(20, ErrorMessage = "Limita de 20 de caractere")]   --- nu sunt sigur daca mai trebuie daca e deja restrictia in tip_tara
        public BD_Tip_Tara? tip_tara { get; set; }

        [ForeignKey("BD_Tip_Student")]
        //[StringLength(20, ErrorMessage = "Limita de 20 de caractere")]   --- nu sunt sigur daca mai trebuie daca e deja restrictia in tip_tara
        public BD_Tip_Student? tip_stud { get; set; }

        [StringLength(3,ErrorMessage ="Limita de 3 caractere")]
        public string? statut { get; set; }

        public int? an { get; set; }

        [ForeignKey("BD_Specializare")]
        public BD_Specializare? id_specializare { get; set; }

        //[StringLength(2, ErrorMessage = "Limita de 2 caractere")]
        //public string? seria { get; set; }

        public int? grupa { get; set; }

        [RegularExpression((@"^\d+(\.\d{1,2})?$"))]//poate avea maxim 2 zecimale
        [Range(0,99999999.99)]//seteaza intervalul de valori, pozitiv pt ca e medie
        public decimal? med_pond { get; set; }

        public byte? valid_sociala { get; set;}

        [StringLength(34, ErrorMessage = "IBAN trebuie sa aiba 34 de caractere")]
        [RegularExpression(@"(.{34})")]
        public string? IBAN { get; set; }
    }
}
