using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("detalleVenta")]
public partial class DetalleVentum
{
    [Column("idProducto")]
    public int IdProducto { get; set; }

    [Key]
    [Column("idDetalleVenta")]
    public int IdDetalleVenta { get; set; }

    [Column("idVenta")]
    public int IdVenta { get; set; }

    [Column("descuento", TypeName = "money")]
    public decimal? Descuento { get; set; }

    [Column("total", TypeName = "money")]
    public decimal? Total { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleVenta")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdVenta")]
    [InverseProperty("DetalleVenta")]
    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}
