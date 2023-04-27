using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("STUDENT")]
public partial class Student
{
    [Key]
    [Column("CNP")]
    [StringLength(13)]
    [Unicode(false)]
    public string Cnp { get; set; } = null!;

    [Column("NUME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nume { get; set; }

    [Column("TIP_TARA")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipTara { get; set; }

    [Column("TIP_STUD")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipStud { get; set; }

    [Column("STATUT")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Statut { get; set; }

    [Column("AN")]
    public int? An { get; set; }

    [Column("ID_SPECIALIZARE")]
    public int? IdSpecializare { get; set; }

    [Column("GRUPA")]
    public int? Grupa { get; set; }

    [Column("MED_POND", TypeName = "numeric(10, 2)")]
    public decimal? MedPond { get; set; }

    [Column("VALID_SOCIALA")]
    public byte? ValidSociala { get; set; }

    [Column("iban")]
    [StringLength(34)]
    [Unicode(false)]
    public string? Iban { get; set; }

    [InverseProperty("CnpNavigation")]
    public virtual ICollection<Abonament> Abonaments { get; set; } = new List<Abonament>();

    [ForeignKey("IdSpecializare")]
    [InverseProperty("Students")]
    public virtual Specializare? IdSpecializareNavigation { get; set; }

    [ForeignKey("TipStud")]
    [InverseProperty("Students")]
    public virtual TipStudent? TipStudNavigation { get; set; }

    [ForeignKey("TipTara")]
    [InverseProperty("Students")]
    public virtual TipTara? TipTaraNavigation { get; set; }
}
