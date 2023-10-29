using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vpersona
{
    [Column("idPersona")]
    public int IdPersona { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("nombreCompleto")]
    public string? NombreCompleto { get; set; }

    [Column("direccion")]
    [StringLength(150)]
    public string? Direccion { get; set; }

    [Column("telefono")]
    [StringLength(12)]
    public string? Telefono { get; set; }

    [Column("correo")]
    [StringLength(50)]
    public string? Correo { get; set; }

    [Column("idTipoDocumento")]
    public int IdTipoDocumento { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }
}
