using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("FACULTATE")]
public partial class Facultate
{
    [Key]
    [Column("ID_FACULTATE")]
    public int IdFacultate { get; set; }

    [Column("DENUMIRE")]
    [StringLength(70)]
    [Unicode(false)]
    public string? Denumire { get; set; }

    [InverseProperty("IdFacultateNavigation")]
    public virtual ICollection<Specializare> Specializares { get; set; } = new List<Specializare>();
}
