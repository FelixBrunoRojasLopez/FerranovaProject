using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vusuario
{
    [Column("idUsuarioAcceso")]
    public int IdUsuarioAcceso { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("changePassword")]
    public bool? ChangePassword { get; set; }

    [Column("correo")]
    [StringLength(80)]
    public string? Correo { get; set; }

    [Column("idRol")]
    public int IdRol { get; set; }

    [Column("celularIdentificador")]
    [StringLength(50)]
    public string? CelularIdentificador { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

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

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }

    [Column("descripcion")]
    [StringLength(255)]
    public string? Descripcion { get; set; }

    [Column("idCargo")]
    public int IdCargo { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("codigo")]
    [StringLength(7)]
    public string? Codigo { get; set; }

    [Column("funcion")]
    [StringLength(100)]
    public string? Funcion { get; set; }

    [Column("nombreCompleto")]
    public string? NombreCompleto { get; set; }

    [Column("idEmpleado")]
    public int IdEmpleado { get; set; }

    [Column("idPersona")]
    public int IdPersona { get; set; }
}
