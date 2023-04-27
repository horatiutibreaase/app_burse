using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend_1.Models;

[Table("TIP_STUDENT")]
public partial class TipStudent
{
    [Key]
    [Column("TIP_STUD")]
    [StringLength(20)]
    [Unicode(false)]
    public string TipStud { get; set; } = null!;

    [InverseProperty("TipStudNavigation")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
