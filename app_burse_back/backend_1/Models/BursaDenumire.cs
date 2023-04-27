using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("bursa_Denumire")]
public partial class BursaDenumire
{
    [Key]
    [Column("denumire")]
    [StringLength(150)]
    [Unicode(false)]
    public string Denumire { get; set; } = null!;
}
