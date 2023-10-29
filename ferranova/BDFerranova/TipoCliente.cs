using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("tipoCliente")]
public partial class TipoCliente
{
    [Key]
    [Column("idTipoCliente", TypeName = "numeric(18, 0)")]
    public decimal IdTipoCliente { get; set; }

    [Column("nombreTipo")]
    [StringLength(50)]
    public string? NombreTipo { get; set; }

    [InverseProperty("IdTipoClienteNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
