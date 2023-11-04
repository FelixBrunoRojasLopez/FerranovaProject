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
    public class MenuRolBusiness : IMenuRolBusiness
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMenuRolRepository _MenuRolRepository;
        private readonly IMapper _mapper;
        public MenuRolBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _MenuRolRepository = new MenuRolRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<MenuRolResponse> GetAll()
        {
            List<MenuRol> MenuRols = _MenuRolRepository.GetAll();
            List<MenuRolResponse> lstResponse = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return lstResponse;
        }

        public MenuRolResponse GetById(int id)
        {
            MenuRol MenuRol = _MenuRolRepository.GetById(id);
            MenuRolResponse resul = _mapper.Map<MenuRolResponse>(MenuRol);
            return resul;
        }

        public MenuRolResponse Create(MenuRolRequest entity)
        {
            MenuRol MenuRol = _mapper.Map<MenuRol>(entity);
            MenuRol = _MenuRolRepository.Create(MenuRol);
            MenuRolResponse result = _mapper.Map<MenuRolResponse>(MenuRol);
            return result;
        }
        public List<MenuRolResponse> InsertMultiple(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            MenuRols = _MenuRolRepository.CreateMultiple(MenuRols);
            List<MenuRolResponse> result = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return result;
        }

        public MenuRolResponse Update(MenuRolRequest entity)
        {
            MenuRol MenuRol = _mapper.Map<MenuRol>(entity);
            MenuRol = _MenuRolRepository.Update(MenuRol);
            MenuRolResponse result = _mapper.Map<MenuRolResponse>(MenuRol);
            return result;
        }

        public List<MenuRolResponse> UpdateMultiple(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            MenuRols = _MenuRolRepository.UpdateMultiple(MenuRols);
            List<MenuRolResponse> result = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _MenuRolRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            int cantidad = _MenuRolRepository.DeleteMultipleItems(MenuRols);
            return cantidad;
        }

        public GenericFilterResponse<MenuRolResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MenuRolResponse> result = _mapper.Map<GenericFilterResponse<MenuRolResponse>>(_MenuRolRepository.GetByFilter(request));

            return result;

        }

        #endregion END CRUD METHODS
    }
}
