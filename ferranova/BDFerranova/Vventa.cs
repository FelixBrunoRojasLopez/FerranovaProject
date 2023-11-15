using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Keyless]
public partial class Vventa
{
    //[Column("idVenta")]
    //public int IdVenta { get; set; }

    //[Column("nombreMetodoPago")]
    //[StringLength(50)]
    //public string? NombreMetodoPago { get; set; }

    //[Column("costoVenta", TypeName = "money")]
    //public decimal? CostoVenta { get; set; }

    //[Column("subtotal", TypeName = "money")]
    //public decimal? Subtotal { get; set; }

    //[Column("fechaVenta")]
    //[Precision(6)]
    //public DateTime? FechaVenta { get; set; }
}
