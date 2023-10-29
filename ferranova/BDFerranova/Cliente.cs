using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("clientes")]
public partial class Cliente
{
    [Key]
    [Column("idCliente")]
    public int IdCliente { get; set; }

    [Column("idPersona")]
    public int IdPersona { get; set; }

    [Column("idTipoPersona")]
    public int IdTipoPersona { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Clientes")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoPersona")]
    [InverseProperty("Clientes")]
    public virtual TipoPersona IdTipoPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
