using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("SPECIALIZARE")]
public partial class Specializare
{
    [Key]
    [Column("ID_SPECIALIZARE")]
    public int IdSpecializare { get; set; }

    [Column("DENUMIRE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Denumire { get; set; }

    [Column("ID_FACULTATE")]
    public int? IdFacultate { get; set; }

    [ForeignKey("IdFacultate")]
    [InverseProperty("Specializares")]
    public virtual Facultate? IdFacultateNavigation { get; set; }

    [InverseProperty("IdSpecializareNavigation")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
