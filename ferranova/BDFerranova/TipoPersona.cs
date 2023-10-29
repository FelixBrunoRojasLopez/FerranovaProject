using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("tipoPersona")]
public partial class TipoPersona
{
    [Key]
    [Column("idTipoPersona")]
    public int IdTipoPersona { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdTipoPersonaNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
