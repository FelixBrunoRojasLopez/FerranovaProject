using BDFerranova;
using IRepository;
using RequestResponseModel;

namespace Repository
    /*
     ":" ==> Hace referencia a POO ==> Herencia
     */
{
    public class CargoRepository : CRUDRepository<Cargo>, ICargoRepository
    {
        public GenericFilterResponse<Cargo> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public Cargo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> InsertMultiple(List<Cargo> lista)
        {
            throw new NotImplementedException();
        }
    }
      
 }