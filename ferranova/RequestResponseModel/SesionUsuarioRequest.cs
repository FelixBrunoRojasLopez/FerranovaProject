using BDFerranova;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class SesionUsuarioRequest
    {
        public int IdSesionUser { get; set; }
        public string? Ip { get; set; }
        public string? Browser { get; set; }
        public string? Token { get; set; }
        public string? TokenRefresh { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActuzalicion { get; set; }
        public int IdUsuarioAcceso { get; set; }
    }
}
