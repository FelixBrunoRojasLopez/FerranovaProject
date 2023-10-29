using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("persona")]
public partial class Persona
{
    [Key]
    [Column("idPersona")]
    public int IdPersona { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("direccion")]
    [StringLength(150)]
    public string? Direccion { get; set; }

    [Column("telefono")]
    [StringLength(12)]
    public string? Telefono { get; set; }

    [Column("fechaNacimiento")]
    [Precision(6)]
    public DateTime? FechaNacimiento { get; set; }

    [Column("correo")]
    [StringLength(50)]
    public string? Correo { get; set; }

    [Column("idTipoDocumento")]
    public int IdTipoDocumento { get; set; }

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }

    [Column("nombreCompleto")]
    public string? NombreCompleto { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

    [ForeignKey("IdTipoDocumento")]
    [InverseProperty("Personas")]
    public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
