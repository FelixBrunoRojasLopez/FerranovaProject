using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("proveedorProducto")]
public partial class ProveedorProducto
{
    [Column("idProveedor")]
    public int IdProveedor { get; set; }

    [Column("idProducto")]
    public int IdProducto { get; set; }

    [Key]
    [Column("idProveedorProducto")]
    public int IdProveedorProducto { get; set; }

    [Column("precioCosto", TypeName = "money")]
    public decimal? PrecioCosto { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("ProveedorProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdProveedor")]
    [InverseProperty("ProveedorProductos")]
    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
