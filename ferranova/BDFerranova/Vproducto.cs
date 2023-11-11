using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vproducto
{
    [Column("idProducto")]
    public int IdProducto { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("stock")]
    public int? Stock { get; set; }

    [Column("precio", TypeName = "money")]
    public decimal? Precio { get; set; }

    [Column("idEstado")]
    public bool? IdEstado { get; set; }
}
