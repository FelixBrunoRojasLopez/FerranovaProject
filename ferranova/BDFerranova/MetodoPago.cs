using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("metodoPago")]
public partial class MetodoPago
{
    [Key]
    [Column("idMetodopago")]
    public int IdMetodopago { get; set; }

    [Column("nombreMetodoPago")]
    [StringLength(50)]
    public string? NombreMetodoPago { get; set; }

    [InverseProperty("IdMetodopagoNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
