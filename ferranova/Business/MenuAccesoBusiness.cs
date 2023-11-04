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
    public class MenuAccesoBusiness : IMenuAccesoBusiness
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMenuAccesoRepository _MenuAccesoRepository;
        private readonly IMapper _mapper;
        public MenuAccesoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _MenuAccesoRepository = new MenuAccesoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<MenuAccesoResponse> GetAll()
        {
            List<MenuAcceso> MenuAccesos = _MenuAccesoRepository.GetAll();
            List<MenuAccesoResponse> lstResponse = _mapper.Map<List<MenuAccesoResponse>>(MenuAccesos);
            return lstResponse;
        }

        public MenuAccesoResponse GetById(int id)
        {
            MenuAcceso MenuAcceso = _MenuAccesoRepository.GetById(id);
            MenuAccesoResponse resul = _mapper.Map<MenuAccesoResponse>(MenuAcceso);
            return resul;
        }

        public MenuAccesoResponse Create(MenuAccesoRequest entity)
        {
            MenuAcceso MenuAcceso = _mapper.Map<MenuAcceso>(entity);
            MenuAcceso = _MenuAccesoRepository.Create(MenuAcceso);
            MenuAccesoResponse result = _mapper.Map<MenuAccesoResponse>(MenuAcceso);
            return result;
        }
        public List<MenuAccesoResponse> InsertMultiple(List<MenuAccesoRequest> lista)
        {
            List<MenuAcceso> MenuAccesos = _mapper.Map<List<MenuAcceso>>(lista);
            MenuAccesos = _MenuAccesoRepository.CreateMultiple(MenuAccesos);
            List<MenuAccesoResponse> result = _mapper.Map<List<MenuAccesoResponse>>(MenuAccesos);
            return result;
        }

        public MenuAccesoResponse Update(MenuAccesoRequest entity)
        {
            MenuAcceso MenuAcceso = _mapper.Map<MenuAcceso>(entity);
            MenuAcceso = _MenuAccesoRepository.Update(MenuAcceso);
            MenuAccesoResponse result = _mapper.Map<MenuAccesoResponse>(MenuAcceso);
            return result;
        }

        public List<MenuAccesoResponse> UpdateMultiple(List<MenuAccesoRequest> lista)
        {
            List<MenuAcceso> MenuAccesos = _mapper.Map<List<MenuAcceso>>(lista);
            MenuAccesos = _MenuAccesoRepository.UpdateMultiple(MenuAccesos);
            List<MenuAccesoResponse> result = _mapper.Map<List<MenuAccesoResponse>>(MenuAccesos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _MenuAccesoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MenuAccesoRequest> lista)
        {
            List<MenuAcceso> MenuAccesos = _mapper.Map<List<MenuAcceso>>(lista);
            int cantidad = _MenuAccesoRepository.DeleteMultipleItems(MenuAccesos);
            return cantidad;
        }

        public GenericFilterResponse<MenuAccesoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MenuAccesoResponse> result = _mapper.Map<GenericFilterResponse<MenuAccesoResponse>>(_MenuAccesoRepository.GetByFilter(request));

            return result;

        }

        #endregion END CRUD METHODS
    }
}