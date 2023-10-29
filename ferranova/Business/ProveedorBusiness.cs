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
    public class ProveedorBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IProveedorRepository _ProveedorRepository;
        private readonly IMapper _mapper;
        public ProveedorBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _ProveedorRepository = new ProveedorRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<ProveedorResponse> GetAll()
        {
            //declarando la lista de Proveedor response como resultado
            List<ProveedorResponse> lstResponse = new List<ProveedorResponse>();
            List<Proveedor> Proveedors = _ProveedorRepository.GetAll();
            lstResponse = _mapper.Map<List<ProveedorResponse>>(Proveedors);
            return lstResponse;
        }
        public ProveedorResponse GetById(int id)
        {
            Proveedor Proveedor = _ProveedorRepository.GetById(id);
            ProveedorResponse resul = _mapper.Map<ProveedorResponse>(Proveedor);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ProveedorResponse Create(ProveedorRequest entity)
        {
            Proveedor Proveedor = _mapper.Map<Proveedor>(entity);
            Proveedor = _ProveedorRepository.Create(Proveedor);
            ProveedorResponse result = _mapper.Map<ProveedorResponse>(entity);
            return result;
        }
        public List<ProveedorResponse> InsertMultiple(List<ProveedorRequest> lista)
        {
            List<Proveedor> Proveedors = _mapper.Map<List<Proveedor>>(lista);
            Proveedors = _ProveedorRepository.InsertMultiple(Proveedors);
            List<ProveedorResponse> result = _mapper.Map<List<ProveedorResponse>>(Proveedors);
            return result;
        }
        public ProveedorResponse Update(ProveedorRequest entity)
        {
            Proveedor Proveedor = _mapper.Map<Proveedor>(entity);
            Proveedor = _ProveedorRepository.Update(Proveedor);
            ProveedorResponse result = _mapper.Map<ProveedorResponse>(entity);
            return result;
        }
        public List<ProveedorResponse> UpdateMultiple(List<ProveedorRequest> lista)
        {
            List<Proveedor> Proveedors = _mapper.Map<List<Proveedor>>(lista);
            Proveedors = _ProveedorRepository.UpdateMultiple(Proveedors);
            List<ProveedorResponse> result = _mapper.Map<List<ProveedorResponse>>(Proveedors);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _ProveedorRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<ProveedorRequest> lista)
        {
            List<Proveedor> Proveedors = _mapper.Map<List<Proveedor>>(lista);
            int cantidad = _ProveedorRepository.DeleteMultipleItems(Proveedors);
            return cantidad;
        }
    }
}