using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("empleado")]
public partial class Empleado
{
    [Key]
    [Column("idEmpleado")]
    public int IdEmpleado { get; set; }

    [Column("idCargo")]
    public int IdCargo { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("idPersona")]
    public int IdPersona { get; set; }

    [ForeignKey("IdCargo")]
    [InverseProperty("Empleados")]
    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    [ForeignKey("IdEstado")]
    [InverseProperty("Empleados")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("Empleados")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<UsuarioAcceso> UsuarioAccesos { get; set; } = new List<UsuarioAcceso>();
}
