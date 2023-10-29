using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("tipoComprobante")]
public partial class TipoComprobante
{
    [Key]
    [Column("idTipoComprobante")]
    public int IdTipoComprobante { get; set; }

    [Column("nombreTipoComprobante")]
    [StringLength(50)]
    public string? NombreTipoComprobante { get; set; }

    [InverseProperty("IdTipoComprobanteNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
