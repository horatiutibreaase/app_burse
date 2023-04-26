using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Keyless]
[Table("BURSA")]
public partial class Bursa
{
    [Column("CNP")]
    [StringLength(13)]
    [Unicode(false)]
    public string? Cnp { get; set; }

    [Column("ID_BURSA")]
    public int IdBursa { get; set; }

    [Column("SEMESTRU")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Semestru { get; set; }

    [Column("DATA_PLATI", TypeName = "datetime")]
    public DateTime? DataPlati { get; set; }

    [Column("PLATIT")]
    public byte? Platit { get; set; }

    [Column("ZILE_PLATI")]
    public int? ZilePlati { get; set; }

    [Column("COD_BURSA")]
    public int? CodBursa { get; set; }

    [ForeignKey("Cnp")]
    public virtual Student? CnpNavigation { get; set; }
}
