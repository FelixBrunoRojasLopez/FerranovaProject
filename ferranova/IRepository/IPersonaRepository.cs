﻿using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IPersonaRepository : ICRUDRepository<Persona>
    {
        List<Persona> InsertMultiple(List<Persona> personas);

        TipoDocumentoFilterResponse ObtenerPorFiltro(TipoDocumentoFilterRequest request);
    }
}
