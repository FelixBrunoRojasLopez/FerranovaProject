using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("proveedor")]
public partial class Proveedor
{
    [Key]
    [Column("idProveedor")]
    public int IdProveedor { get; set; }

    [Column("ruc")]
    [StringLength(15)]
    public string? Ruc { get; set; }

    [Column("idPersona")]
    public int IdPersona { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Proveedors")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<ProveedorProducto> ProveedorProductos { get; set; } = new List<ProveedorProducto>();
}
