using AutoMapper;
using BDFerranova;
using IBusiness;
using IRepository;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonaBusiness : IPersonaBusiness
    { 
     //Inyeccion de Dependecias
    #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IPersonaRepository _PersonaRepository;
        private readonly IMapper _mapper;
    public PersonaBusiness(IMapper mapper)
    {
        _mapper = mapper;
        _PersonaRepository = new PersonaRepository(mapper);
    }
    #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
    public List<PersonaResponse> GetAll()
    {
        //declarando la lista de Persona response como resultado
        List<PersonaResponse> lstResponse = new List<PersonaResponse>();
        List<Persona> Personas = _PersonaRepository.GetAll();
        lstResponse = _mapper.Map<List<PersonaResponse>>(Personas);
        return lstResponse;
    }
    public PersonaResponse GetById(int id)
    {
        Persona Persona = _PersonaRepository.GetById(id);
        PersonaResponse resul = _mapper.Map<PersonaResponse>(Persona);
        return resul;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public PersonaResponse Create(PersonaRequest entity)
    {
        Persona Persona = _mapper.Map<Persona>(entity);
        Persona = _PersonaRepository.Create(Persona);
        PersonaResponse result = _mapper.Map<PersonaResponse>(entity);
        return result;
    }
    public List<PersonaResponse> InsertMultiple(List<PersonaRequest> lista)
    {
        List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
        Personas = _PersonaRepository.InsertMultiple(Personas);
        List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
        return result;
    }
    public PersonaResponse Update(PersonaRequest entity)
    {
        Persona Persona = _mapper.Map<Persona>(entity);
        Persona = _PersonaRepository.Update(Persona);
        PersonaResponse result = _mapper.Map<PersonaResponse>(entity);
        return result;
    }
    public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> lista)
    {
        List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
        Personas = _PersonaRepository.UpdateMultiple(Personas);
        List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
        return result;
    }
    public int Delete(int id)
    {
        int cantidad = _PersonaRepository.Delete(id);
        return cantidad;
    }
    public int DeleteMultipleItems(List<PersonaRequest> lista)
    {
        List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
        int cantidad = _PersonaRepository.DeleteMultipleItems(Personas);
        return cantidad;
    }

        public TipoDocumentoFilterResponse ObtenerPorFiltro(TipoDocumentoFilterRequest request)
        {
            return _PersonaRepository.ObtenerPorFiltro(request); 
        }

        public GenericFilterResponse<PersonaResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PersonaResponse> result = _mapper.Map<GenericFilterResponse<PersonaResponse>>(_PersonaRepository.GetByFilter(request));

            return result;

        }
    }
}
   