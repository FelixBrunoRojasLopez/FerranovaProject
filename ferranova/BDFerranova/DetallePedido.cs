using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("detallePedido")]
public partial class DetallePedido
{
    [Column("idProducto")]
    public int IdProducto { get; set; }

    [Column("idPedidos")]
    public int IdPedidos { get; set; }

    [Key]
    [Column("idDetallePedido")]
    public int IdDetallePedido { get; set; }

    [ForeignKey("IdPedidos")]
    [InverseProperty("DetallePedidos")]
    public virtual Pedido IdPedidosNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetallePedidos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
