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
    public class UsuarioBusiness : IUsuarioBusiness
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioRepository = new UsuarioRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<UsuarioResponse> GetAll()
        {
            List<UsuarioAcceso> Usuarios = _UsuarioRepository.GetAll();
            List<UsuarioResponse> lstResponse = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return lstResponse;
        }

        public UsuarioResponse GetById(int id)
        {
            UsuarioAcceso Usuario = _UsuarioRepository.GetById(id);
            UsuarioResponse resul = _mapper.Map<UsuarioResponse>(Usuario);
            return resul;
        }

        public UsuarioResponse Create(UsuarioRequest entity)
        {
            UsuarioAcceso Usuario = _mapper.Map<UsuarioAcceso>(entity);
            Usuario = _UsuarioRepository.Create(Usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(Usuario);
            return result;
        }
        public List<UsuarioResponse> InsertMultiple(List<UsuarioRequest> lista)
        {
            List<UsuarioAcceso> Usuarios = _mapper.Map<List<UsuarioAcceso>>(lista);
            Usuarios = _UsuarioRepository.CreateMultiple(Usuarios);
            List<UsuarioResponse> result = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return result;
        }

        public UsuarioResponse Update(UsuarioRequest entity)
        {
            UsuarioAcceso Usuario = _mapper.Map<UsuarioAcceso>(entity);
            Usuario = _UsuarioRepository.Update(Usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(Usuario);
            return result;
        }

        public List<UsuarioResponse> UpdateMultiple(List<UsuarioRequest> lista)
        {
            List<UsuarioAcceso> Usuarios = _mapper.Map<List<UsuarioAcceso>>(lista);
            Usuarios = _UsuarioRepository.UpdateMultiple(Usuarios);
            List<UsuarioResponse> result = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _UsuarioRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<UsuarioRequest> lista)
        {
            List<UsuarioAcceso> Usuarios = _mapper.Map<List<UsuarioAcceso>>(lista);
            int cantidad = _UsuarioRepository.DeleteMultipleItems(Usuarios);
            return cantidad;
        }

        #endregion END CRUD METHODS
        public UsuarioResponse BuscarPorNombreUsuario(string username)
        {
            UsuarioResponse Usuario =
                _mapper.Map<UsuarioResponse>
                (_UsuarioRepository.ObtenerPorUsername(username));
                return Usuario;
        }
        public Vusuario ObtenerVistaUsername(string username)
        {
            Vusuario Usuario = _UsuarioRepository.ObtenerVistaUsername(username);
            return Usuario;
        }

        public GenericFilterResponse<UsuarioResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<UsuarioResponse> result = _mapper.Map<GenericFilterResponse<UsuarioResponse>>(_UsuarioRepository.GetByFilter(request));

            return result;

        }
    }
}

