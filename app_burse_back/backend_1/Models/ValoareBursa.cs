using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Keyless]
[Table("valoare_bursa")]
public partial class ValoareBursa
{
    [Column("id_bursa")]
    public int? IdBursa { get; set; }

    [Column("denumire")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Denumire { get; set; }

    [Column("cuantum", TypeName = "numeric(10, 2)")]
    public decimal? Cuantum { get; set; }

    [ForeignKey("Denumire")]
    public virtual BursaDenumire? DenumireNavigation { get; set; }
}
