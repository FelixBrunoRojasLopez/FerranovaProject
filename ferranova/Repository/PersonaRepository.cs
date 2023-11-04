using AutoMapper;
using BDFerranova;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonaRepository : CRUDRepository<Persona>, IPersonaRepository
    {
        _dbFerranovaContext db = null;
        private readonly IMapper _mapper;
        public PersonaRepository(IMapper mapper)
        {
            db = new _dbFerranovaContext();
            _mapper = mapper;
        }

        
        public List<Persona> InsertMultiple(List<Persona> personas)
        {
            throw new NotImplementedException();
        }

        

        public TipoDocumentoFilterResponse ObtenerPorFiltro(TipoDocumentoFilterRequest request)
        {
            var query = db.Personas.Where(x => x.IdPersona == x.IdPersona);
            if (request.Id != 0)
            {
                query = query.Where(x => x.IdPersona == request.Id);
            }
            if (!string.IsNullOrEmpty(request.NroDocumento))
            {
                query = query.Where(x =>
                x.NroDocumento.ToLower().Contains(request.NroDocumento.ToLower()));
            }
            if (!string.IsNullOrEmpty(request.Nombre))
            {
                query = query.Where(x =>
                x.Nombre.ToLower().Contains(request.Nombre.ToLower()));
            }
            /*
             * ARMANDO PROCESO DE PAGINACION
             */
            List<Persona> lista = query.
                Skip((request.Pagina - 1) * request.Cantidad).
                Take(request.Cantidad).
                OrderBy(x => x.NroDocumento).
                ToList();

            TipoDocumentoFilterResponse res = new TipoDocumentoFilterResponse();
            res.CantidadTotalRegistros = query.Count();
            res.Lista = _mapper.Map<List<PersonaResponse>>(lista);
            return res;
        }
    }
}
