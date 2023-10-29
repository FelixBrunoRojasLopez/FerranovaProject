using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("detalleProducto")]
public partial class DetalleProducto
{
    [Key]
    [Column("idDetalleProducto")]
    public int IdDetalleProducto { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [InverseProperty("IdDetalleProductoNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
