using AutoMapper;
using BDFerranova;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Vml.Office;
using IBusiness;
using IRepository;
using Repository;
using RequestResponseModel;

namespace Business
{
    public class CargoBusiness : ICargoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ICargoRepository _cargoRepository;
        private readonly IMapper _mapper;
        public CargoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _cargoRepository = new CargoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<CargoResponse> GetAll()
        {
            //declarando la lista de cargo response como resultado
            List<CargoResponse> lstResponse = new List<CargoResponse>();
            List<Cargo> cargos = _cargoRepository.GetAll(); 
            lstResponse = _mapper.Map<List<CargoResponse>>(cargos);
            return lstResponse;
        }
        public CargoResponse GetById(int id)
        {
            Cargo cargo = _cargoRepository.GetById(id);
            CargoResponse resul = _mapper.Map<CargoResponse>(cargo);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
        public CargoResponse Create(CargoRequest entity)
        {
            Cargo cargo = _mapper.Map<Cargo>(entity);
            cargo = _cargoRepository.Create(cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(entity);
            return result;
        }
        public List<CargoResponse> InsertMultiple(List<CargoRequest> lista)
        {
            List<Cargo> cargos = _mapper.Map<List<Cargo>>(lista);
            cargos = _cargoRepository.InsertMultiple(cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(cargos);
            return result;
        }
        public CargoResponse Update(CargoRequest entity)
        {
            Cargo cargo = _mapper.Map<Cargo>(entity);
            cargo = _cargoRepository.Update(cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(entity);
            return result;
        }
        public List<CargoResponse> UpdateMultiple(List<CargoRequest> lista)
        {
            List<Cargo> cargos = _mapper.Map<List<Cargo>>(lista);
            cargos = _cargoRepository.UpdateMultiple(cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(cargos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _cargoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<CargoRequest> lista)
        {
            List<Cargo> cargos = _mapper.Map<List<Cargo>>(lista);
            int cantidad = _cargoRepository.DeleteMultipleItems(cargos);
            return cantidad;
        }

        public GenericFilterResponse<CargoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<CargoResponse> result = _mapper.Map<GenericFilterResponse<CargoResponse>>(_cargoRepository.GetByFilter(request));

            return result;

        }
    }
}