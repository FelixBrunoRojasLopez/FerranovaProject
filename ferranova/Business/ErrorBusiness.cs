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
    public class ErrorBusiness : IErrorBusiness
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IErrorRepository _ErrorRepository;
        private readonly IMapper _mapper;
        public ErrorBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _ErrorRepository = new ErrorRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<ErrorResponse> GetAll()
        {
            List<Error> Errors = _ErrorRepository.GetAll();
            List<ErrorResponse> lstResponse = _mapper.Map<List<ErrorResponse>>(Errors);
            return lstResponse;
        }

        public ErrorResponse GetById(int id)
        {
            Error Error = _ErrorRepository.GetById(id);
            ErrorResponse resul = _mapper.Map<ErrorResponse>(Error);
            return resul;
        }

        public ErrorResponse Create(ErrorRequest entity)
        {
            Error Error = _mapper.Map<Error>(entity);
            Error = _ErrorRepository.Create(Error);
            ErrorResponse result = _mapper.Map<ErrorResponse>(Error);
            return result;
        }
        public List<ErrorResponse> InsertMultiple(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            Errors = _ErrorRepository.CreateMultiple(Errors);
            List<ErrorResponse> result = _mapper.Map<List<ErrorResponse>>(Errors);
            return result;
        }

        public ErrorResponse Update(ErrorRequest entity)
        {
            Error Error = _mapper.Map<Error>(entity);
            Error = _ErrorRepository.Update(Error);
            ErrorResponse result = _mapper.Map<ErrorResponse>(Error);
            return result;
        }

        public List<ErrorResponse> UpdateMultiple(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            Errors = _ErrorRepository.UpdateMultiple(Errors);
            List<ErrorResponse> result = _mapper.Map<List<ErrorResponse>>(Errors);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _ErrorRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            int cantidad = _ErrorRepository.DeleteMultipleItems(Errors);
            return cantidad;
        }

        #endregion END CRUD METHODS
       }
}