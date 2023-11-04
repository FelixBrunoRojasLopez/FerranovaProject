using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("estado")]
public partial class Estado
{
    [Key]
    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("decripcionEstado")]
    [StringLength(50)]
    public string? DecripcionEstado { get; set; }

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<MenuAcceso> MenuAccesos { get; set; } = new List<MenuAcceso>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    [InverseProperty("IdEstadoNavigation")]
    public virtual ICollection<UsuarioAcceso> UsuarioAccesos { get; set; } = new List<UsuarioAcceso>();
}
