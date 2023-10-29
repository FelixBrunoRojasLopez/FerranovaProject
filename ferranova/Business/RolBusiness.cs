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
    public class RolBusiness : IRolBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IRolRepository _RolRepository;
        private readonly IMapper _mapper;
        public RolBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _RolRepository = new RolRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<RolResponse> GetAll()
        {
            //declarando la lista de Rol response como resultado
            List<RolResponse> lstResponse = new List<RolResponse>();
            List<Rol> Rols = _RolRepository.GetAll();
            lstResponse = _mapper.Map<List<RolResponse>>(Rols);
            return lstResponse;
        }
        public RolResponse GetById(int id)
        {
            Rol Rol = _RolRepository.GetByID(id);
            RolResponse resul = _mapper.Map<RolResponse>(Rol);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public RolResponse Create(RolRequest entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Create(Rol);
            RolResponse result = _mapper.Map<RolResponse>(entity);
            return result;
        }
        public List<RolResponse> InsertMultiple(List<RolRequest> lista)
        {
            List<Rol> Rols = _mapper.Map<List<Rol>>(lista);
            Rols = _RolRepository.InsertMultiple(Rols);
            List<RolResponse> result = _mapper.Map<List<RolResponse>>(Rols);
            return result;
        }
        public RolResponse Update(RolRequest entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Update(Rol);
            RolResponse result = _mapper.Map<RolResponse>(entity);
            return result;
        }
        public List<RolResponse> UpdateMultiple(List<RolRequest> lista)
        {
            List<Rol> Rols = _mapper.Map<List<Rol>>(lista);
            Rols = _RolRepository.UpdateMultiple(Rols);
            List<RolResponse> result = _mapper.Map<List<RolResponse>>(Rols);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _RolRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<RolRequest> lista)
        {
            List<Rol> Rols = _mapper.Map<List<Rol>>(lista);
            int cantidad = _RolRepository.DeleteMultipleItems(Rols);
            return cantidad;
        }
    }
}