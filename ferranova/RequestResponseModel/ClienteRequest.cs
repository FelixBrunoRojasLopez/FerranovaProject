﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ClienteRequest
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoPersona { get; set; }
    }
}
