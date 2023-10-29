using BDFerranova;
using IRepository;

namespace Repository
    /*
     ":" ==> Hace referencia a POO ==> Herencia
     */
{
    public class CargoRepository : CRUDRepository<Cargo>, ICargoRepository
    {
        

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