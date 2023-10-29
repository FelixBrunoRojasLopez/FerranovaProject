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
    public class EmpleadoBusiness : IEmpleadoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IEmpleadoRepository _EmpleadoRepository;
        private readonly IMapper _mapper;
        public EmpleadoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _EmpleadoRepository = new EmpleadoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<EmpleadoResponse> GetAll()
        {
            //declarando la lista de Empleado response como resultado
            List<EmpleadoResponse> lstResponse = new List<EmpleadoResponse>();
            List<Empleado> Empleados = _EmpleadoRepository.GetAll();
            lstResponse = _mapper.Map<List<EmpleadoResponse>>(Empleados);
            return lstResponse;
        }
        public EmpleadoResponse GetById(int id)
        {
            Empleado Empleado = _EmpleadoRepository.GetById(id);
            EmpleadoResponse resul = _mapper.Map<EmpleadoResponse>(Empleado);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public EmpleadoResponse Create(EmpleadoRequest entity)
        {
            Empleado Empleado = _mapper.Map<Empleado>(entity);
            Empleado = _EmpleadoRepository.Create(Empleado);
            EmpleadoResponse result = _mapper.Map<EmpleadoResponse>(entity);
            return result;
        }
        public List<EmpleadoResponse> InsertMultiple(List<EmpleadoRequest> lista)
        {
            List<Empleado> Empleados = _mapper.Map<List<Empleado>>(lista);
            Empleados = _EmpleadoRepository.InsertMultiple(Empleados);
            List<EmpleadoResponse> result = _mapper.Map<List<EmpleadoResponse>>(Empleados);
            return result;
        }
        public EmpleadoResponse Update(EmpleadoRequest entity)
        {
            Empleado Empleado = _mapper.Map<Empleado>(entity);
            Empleado = _EmpleadoRepository.Update(Empleado);
            EmpleadoResponse result = _mapper.Map<EmpleadoResponse>(entity);
            return result;
        }
        public List<EmpleadoResponse> UpdateMultiple(List<EmpleadoRequest> lista)
        {
            List<Empleado> Empleados = _mapper.Map<List<Empleado>>(lista);
            Empleados = _EmpleadoRepository.UpdateMultiple(Empleados);
            List<EmpleadoResponse> result = _mapper.Map<List<EmpleadoResponse>>(Empleados);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _EmpleadoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<EmpleadoRequest> lista)
        {
            List<Empleado> Empleados = _mapper.Map<List<Empleado>>(lista);
            int cantidad = _EmpleadoRepository.DeleteMultipleItems(Empleados);
            return cantidad;
        }
    }
}
    

