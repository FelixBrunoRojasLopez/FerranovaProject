using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("NumeroDoc")]
public partial class NumeroDoc
{
    [Key]
    [Column("idNumDoc")]
    public int IdNumDoc { get; set; }

    [Column("ultimoNumero")]
    public int UltimoNumero { get; set; }

    [Column("fechaRegistro")]
    public DateTime? FechaRegistro { get; set; }
}
