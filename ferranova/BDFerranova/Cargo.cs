using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("cargo")]
public partial class Cargo
{
    [Key]
    [Column("idCargo")]
    public int IdCargo { get; set; }

    [Column("descripcionCargo")]
    [StringLength(50)]
    public string? DescripcionCargo { get; set; }

    [Column("codigo")]
    [StringLength(8)]
    public string? Codigo { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [InverseProperty("IdCargoNavigation")]
    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    [ForeignKey("IdEstado")]
    [InverseProperty("Cargos")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;
}
