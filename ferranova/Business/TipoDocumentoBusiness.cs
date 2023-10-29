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
    public class TipoDocumentoBusiness : ITipoDocumentoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ITipoDocumentoRepository _TipoDocumentoRepository;
        private readonly IMapper _mapper;
        public TipoDocumentoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _TipoDocumentoRepository = new TipoDocumentoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<TipoDocumentoResponse> GetAll()
        {
            //declarando la lista de TipoDocumento response como resultado
            List<TipoDocumentoResponse> lstResponse = new List<TipoDocumentoResponse>();
            List<TipoDocumento> TipoDocumentos = _TipoDocumentoRepository.GetAll();
            lstResponse = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return lstResponse;
        }
        public TipoDocumentoResponse GetById(int id)
        {
            TipoDocumento TipoDocumento = _TipoDocumentoRepository.GetById(id);
            TipoDocumentoResponse resul = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = _TipoDocumentoRepository.Create(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(entity);
            return result;
        }
        public List<TipoDocumentoResponse> InsertMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = _TipoDocumentoRepository.InsertMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }
        public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = _TipoDocumentoRepository.Update(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(entity);
            return result;
        }
        public List<TipoDocumentoResponse> UpdateMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = _TipoDocumentoRepository.UpdateMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _TipoDocumentoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            int cantidad = _TipoDocumentoRepository.DeleteMultipleItems(TipoDocumentos);
            return cantidad;
        }
    }
}
