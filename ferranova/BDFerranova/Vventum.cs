using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vventum
{
    [Column("idV")]
    public int IdV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroDoc { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("nroDocumento")]
    [StringLength(20)]
    public string? NroDocumento { get; set; }

    [Column("nombreMetodoPago")]
    [StringLength(50)]
    public string? NombreMetodoPago { get; set; }

    [Column("total", TypeName = "decimal(10, 2)")]
    public decimal? Total { get; set; }

    [Column("fechaVenta")]
    [Precision(6)]
    public DateTime? FechaVenta { get; set; }
}
