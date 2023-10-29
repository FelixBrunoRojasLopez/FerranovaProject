using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("usuarioAcceso")]
public partial class UsuarioAcceso
{
    [Key]
    [Column("idUsuarioAcceso")]
    public int IdUsuarioAcceso { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("idEmpleado")]
    public int IdEmpleado { get; set; }

    [Column("changePassword")]
    public bool? ChangePassword { get; set; }

    [Column("correo")]
    [StringLength(80)]
    public string? Correo { get; set; }

    [Column("creaUsuario")]
    public int CreaUsuario { get; set; }

    [Column("actualizaUsuario")]
    public int ActualizaUsuario { get; set; }

    [Column("fechaDeCreacion")]
    [Precision(6)]
    public DateTime FechaDeCreacion { get; set; }

    [Column("fechaDeActulizacion")]
    [Precision(6)]
    public DateTime FechaDeActulizacion { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("idRol")]
    public int IdRol { get; set; }

    [Column("celularIdentificador")]
    [StringLength(50)]
    public string? CelularIdentificador { get; set; }

    [InverseProperty("IdUsuarioAccesoNavigation")]
    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

    [ForeignKey("IdEmpleado")]
    [InverseProperty("UsuarioAccesos")]
    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEstado")]
    [InverseProperty("UsuarioAccesos")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    [ForeignKey("IdRol")]
    [InverseProperty("UsuarioAccesos")]
    public virtual Rol IdRolNavigation { get; set; } = null!;

    [InverseProperty("IdUsuarioAccesoNavigation")]
    public virtual ICollection<SesionUsuario> SesionUsuarios { get; set; } = new List<SesionUsuario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
