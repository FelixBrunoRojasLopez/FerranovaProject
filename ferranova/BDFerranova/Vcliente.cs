using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vcliente
{
    [Column("idCliente")]
    public int IdCliente { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }

    [Column("correo")]
    [StringLength(50)]
    public string? Correo { get; set; }

    [Column("telefono")]
    [StringLength(12)]
    public string? Telefono { get; set; }
}
