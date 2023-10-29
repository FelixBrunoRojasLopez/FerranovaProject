using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("menuRol")]
public partial class MenuRol
{
    [Key]
    [Column("idMenuRol")]
    public int IdMenuRol { get; set; }

    [Column("idRol")]
    public int IdRol { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; }

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }

    [Column("idMenu")]
    public int IdMenu { get; set; }

    [ForeignKey("IdEstado")]
    [InverseProperty("MenuRols")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    [ForeignKey("IdMenu")]
    [InverseProperty("MenuRols")]
    public virtual MenuAcceso IdMenuNavigation { get; set; } = null!;

    [ForeignKey("IdRol")]
    [InverseProperty("MenuRols")]
    public virtual Rol IdRolNavigation { get; set; } = null!;
}
