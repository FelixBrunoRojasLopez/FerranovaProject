using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vempleado
{
    [Column("idEmpleado")]
    public int IdEmpleado { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("descripcionCargo")]
    [StringLength(50)]
    public string? DescripcionCargo { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("decripcionEstado")]
    [StringLength(50)]
    public string? DecripcionEstado { get; set; }

    [Column("telefono")]
    [StringLength(12)]
    public string? Telefono { get; set; }

    [Column("fechaNacimiento")]
    [Precision(6)]
    public DateTime? FechaNacimiento { get; set; }

    [Column("correo")]
    [StringLength(50)]
    public string? Correo { get; set; }

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }
}
