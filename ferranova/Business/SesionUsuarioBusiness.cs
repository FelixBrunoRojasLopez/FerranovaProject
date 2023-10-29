using AutoMapper;
using BDFerranova;
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
    public class SesionUsuarioBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ISesionUsuarioRepository _SesionUsuarioRepository;
        private readonly IMapper _mapper;
        public SesionUsuarioBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _SesionUsuarioRepository = new SesionUsuarioRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<SesionUsuarioResponse> GetAll()
        {
            //declarando la lista de SesionUsuario response como resultado
            List<SesionUsuarioResponse> lstResponse = new List<SesionUsuarioResponse>();
            List<SesionUsuario> SesionUsuarios = _SesionUsuarioRepository.GetAll();
            lstResponse = _mapper.Map<List<SesionUsuarioResponse>>(SesionUsuarios);
            return lstResponse;
        }
        public SesionUsuarioResponse GetById(int id)
        {
            SesionUsuario SesionUsuario = _SesionUsuarioRepository.GetById(id);
            SesionUsuarioResponse resul = _mapper.Map<SesionUsuarioResponse>(SesionUsuario);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public SesionUsuarioResponse Create(SesionUsuarioRequest entity)
        {
            SesionUsuario SesionUsuario = _mapper.Map<SesionUsuario>(entity);
            SesionUsuario = _SesionUsuarioRepository.Create(SesionUsuario);
            SesionUsuarioResponse result = _mapper.Map<SesionUsuarioResponse>(entity);
            return result;
        }
        public List<SesionUsuarioResponse> InsertMultiple(List<SesionUsuarioRequest> lista)
        {
            List<SesionUsuario> SesionUsuarios = _mapper.Map<List<SesionUsuario>>(lista);
            SesionUsuarios = _SesionUsuarioRepository.InsertMultiple(SesionUsuarios);
            List<SesionUsuarioResponse> result = _mapper.Map<List<SesionUsuarioResponse>>(SesionUsuarios);
            return result;
        }
        public SesionUsuarioResponse Update(SesionUsuarioRequest entity)
        {
            SesionUsuario SesionUsuario = _mapper.Map<SesionUsuario>(entity);
            SesionUsuario = _SesionUsuarioRepository.Update(SesionUsuario);
            SesionUsuarioResponse result = _mapper.Map<SesionUsuarioResponse>(entity);
            return result;
        }
        public List<SesionUsuarioResponse> UpdateMultiple(List<SesionUsuarioRequest> lista)
        {
            List<SesionUsuario> SesionUsuarios = _mapper.Map<List<SesionUsuario>>(lista);
            SesionUsuarios = _SesionUsuarioRepository.UpdateMultiple(SesionUsuarios);
            List<SesionUsuarioResponse> result = _mapper.Map<List<SesionUsuarioResponse>>(SesionUsuarios);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _SesionUsuarioRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<SesionUsuarioRequest> lista)
        {
            List<SesionUsuario> SesionUsuarios = _mapper.Map<List<SesionUsuario>>(lista);
            int cantidad = _SesionUsuarioRepository.DeleteMultipleItems(SesionUsuarios);
            return cantidad;
        }
    }
}
