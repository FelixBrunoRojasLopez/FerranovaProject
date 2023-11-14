using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("producto")]
public partial class Producto
{
    [Key]
    [Column("idProducto")]
    public int IdProducto { get; set; }

    [Column("idDetalleProducto")]
    public int IdDetalleProducto { get; set; } // Id, Detalle, otros datos donde utiliza es front lista visualis ens el nom interna esta ordena por id
    // valaor que manda es Id

    [Column("stock")]
    public int? Stock { get; set; }

    [Column("precio", TypeName = "money")]
    public decimal? Precio { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("imagen", TypeName = "image")]
    public byte[]? Imagen { get; set; }

    [Column("fechaRegistro")]
    public DateTime? FechaRegistro { get; set; }

    [Column("idEstado")]
    public bool? IdEstado { get; set; } // id, nombre, otros datos 

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    [ForeignKey("IdDetalleProducto")]
    [InverseProperty("Productos")]
    public virtual DetalleProducto IdDetalleProductoNavigation { get; set; } = null!;

    [ForeignKey("IdEstado")]
    [InverseProperty("Productos")]
    public virtual Estado? IdEstadoNavigation { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<ProveedorProducto> ProveedorProductos { get; set; } = new List<ProveedorProducto>();
}
