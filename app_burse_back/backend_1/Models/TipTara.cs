using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("TIP_TARA")]
public partial class TipTara
{
    [Key]
    [Column("TIP_TARA")]
    [StringLength(20)]
    [Unicode(false)]
    public string TipTara1 { get; set; } = null!;

    [InverseProperty("TipTaraNavigation")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
