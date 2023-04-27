using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Keyless]
[Table("TIP_ABONAMENT")]
public partial class TipAbonament
{
    [Column("COD_ABO")]
    public int? CodAbo { get; set; }

    [Column("DENUMIRE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Denumire { get; set; }

    [Column("CUANTUM", TypeName = "numeric(10, 2)")]
    public decimal? Cuantum { get; set; }

    [ForeignKey("CodAbo")]
    public virtual Abonament? CodAboNavigation { get; set; }
}
