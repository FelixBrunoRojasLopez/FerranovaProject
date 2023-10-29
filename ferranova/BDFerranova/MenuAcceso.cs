using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("menuAcceso")]
public partial class MenuAcceso
{
    [Key]
    [Column("idMenu")]
    public int IdMenu { get; set; }

    [Column("nombre")]
    [StringLength(100)]
    public string? Nombre { get; set; }

    [Column("descripcion")]
    [StringLength(200)]
    public string? Descripcion { get; set; }

    [Column("icono")]
    [StringLength(50)]
    public string? Icono { get; set; }

    [Column("datatarget")]
    [StringLength(50)]
    public string? Datatarget { get; set; }

    [Column("url")]
    [StringLength(100)]
    public string? Url { get; set; }

    [Column("padre")]
    public int Padre { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; }

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }

    [ForeignKey("IdEstado")]
    [InverseProperty("MenuAccesos")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    [InverseProperty("IdMenuNavigation")]
    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();
}
