using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

[Table("error")]
public partial class Error
{
    [Key]
    [Column("idError")]
    public int IdError { get; set; }

    [Column("url")]
    [StringLength(100)]
    public string? Url { get; set; }

    [Column("controller")]
    [StringLength(200)]
    public string? Controller { get; set; }

    [Column("ip")]
    [StringLength(100)]
    public string? Ip { get; set; }

    [Column("method")]
    [StringLength(20)]
    public string? Method { get; set; }

    [Column("userAgent")]
    [StringLength(150)]
    public string? UserAgent { get; set; }

    [Column("host")]
    [StringLength(100)]
    public string? Host { get; set; }

    [Column("classComponent")]
    [StringLength(100)]
    public string? ClassComponent { get; set; }

    [Column("functionName")]
    [StringLength(100)]
    public string? FunctionName { get; set; }

    [Column("lineNumber")]
    public int? LineNumber { get; set; }

    [Column("error")]
    [StringLength(200)]
    public string? Error1 { get; set; }

    [Column("stackTrace")]
    [StringLength(200)]
    public string? StackTrace { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("request")]
    public string? Request { get; set; }

    [Column("errorCode")]
    public int ErrorCode { get; set; }

    [Column("idPersona")]
    public int IdPersona { get; set; }

    [Column("idUsuarioAcceso")]
    public int IdUsuarioAcceso { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Errors")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdUsuarioAcceso")]
    [InverseProperty("Errors")]
    public virtual UsuarioAcceso IdUsuarioAccesoNavigation { get; set; } = null!;
}
