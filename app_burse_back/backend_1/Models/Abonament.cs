using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("ABONAMENT")]
public partial class Abonament
{
    [Key]
    [Column("COD_ABO")]
    public int CodAbo { get; set; }

    [Column("CNP")]
    [StringLength(13)]
    [Unicode(false)]
    public string? Cnp { get; set; }

    [Column("LUNA")]
    public int? Luna { get; set; }

    [Column("PLATIT")]
    public byte? Platit { get; set; }

    [Column("DATA_PLATI", TypeName = "datetime")]
    public DateTime? DataPlati { get; set; }

    [Column("DATA_IN", TypeName = "datetime")]
    public DateTime? DataIn { get; set; }

    [Column("DATA_OP", TypeName = "datetime")]
    public DateTime? DataOp { get; set; }

    [ForeignKey("Cnp")]
    [InverseProperty("Abonaments")]
    public virtual Student? CnpNavigation { get; set; }
}
