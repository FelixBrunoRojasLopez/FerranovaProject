using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("rol")]
public partial class Rol
{
    [Key]
    [Column("idRol")]
    public int IdRol { get; set; }

    [Column("codigo")]
    [StringLength(7)]
    public string? Codigo { get; set; }

    [Column("descripcion")]
    [StringLength(255)]
    public string? Descripcion { get; set; }

    [Column("funcion")]
    [StringLength(100)]
    public string? Funcion { get; set; }

    [Column("idEstado")]
    public bool IdEstado { get; set; }

    [ForeignKey("IdEstado")]
    [InverseProperty("Rols")]
    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<UsuarioAcceso> UsuarioAccesos { get; set; } = new List<UsuarioAcceso>();
}
