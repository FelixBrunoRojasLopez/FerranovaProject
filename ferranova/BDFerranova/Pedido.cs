using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("pedidos")]
public partial class Pedido
{
    [Key]
    [Column("idPedidos")]
    public int IdPedidos { get; set; }

    [Column("fechaEntrega", TypeName = "datetime")]
    public DateTime FechaEntrega { get; set; }

    [Column("hora")]
    public TimeSpan? Hora { get; set; }

    [Column("descripcion")]
    [StringLength(100)]
    public string? Descripcion { get; set; }

    [Column("idCliente")]
    public int IdCliente { get; set; }

    [Column("cantidad")]
    public short? Cantidad { get; set; }

    [InverseProperty("IdPedidosNavigation")]
    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Pedidos")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
