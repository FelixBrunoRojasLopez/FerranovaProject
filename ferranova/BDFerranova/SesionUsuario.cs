using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("sesionUsuario")]
public partial class SesionUsuario
{
    [Key]
    [Column("idSesionUser")]
    public int IdSesionUser { get; set; }

    [Column("ip")]
    public string? Ip { get; set; }

    [Column("browser")]
    public string? Browser { get; set; }

    [Column("token")]
    public string? Token { get; set; }

    [Column("tokenRefresh")]
    public string? TokenRefresh { get; set; }

    [Column("fechaCreacion")]
    [Precision(6)]
    public DateTime FechaCreacion { get; set; }

    [Column("fechaActuzalicion")]
    [Precision(6)]
    public DateTime FechaActuzalicion { get; set; }

    [Column("idUsuarioAcceso")]
    public int IdUsuarioAcceso { get; set; }

    [ForeignKey("IdUsuarioAcceso")]
    [InverseProperty("SesionUsuarios")]
    public virtual UsuarioAcceso IdUsuarioAccesoNavigation { get; set; } = null!;
}
