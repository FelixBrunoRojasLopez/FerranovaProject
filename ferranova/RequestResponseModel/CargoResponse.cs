﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class CargoResponse
    {
        public int IdCargo { get; set; }
        public string? DescripcionCargo { get; set; } = "";
        public string? Codigo { get; set; } = "";
        public bool IdEstado { get; set; }=false;
        public string EstadoDescripcion
        {
            get
            {
            return IdEstado ? "Activo":"Inactivo";
            }
        }
    }
}
