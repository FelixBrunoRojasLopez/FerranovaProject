using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    /*
     Programacion orientada a objetos
    Public, Internal, Private => Encapsulamiento
     */
    public interface ICargoRepository : ICRUDRepository<Cargo>
    {
        //List<Cargo> GetAll();
        //Cargo GetById(int id);
        //Cargo Create(Cargo entity);
        //Cargo Update(Cargo entity);

        //int Delete(int id);
        //int DeleteMultipleItems(List<Cargo> lista);

        //List<Cargo> InsertMultiple(List<Cargo> lista);
        //List<Cargo> UpdateMultiple(List<Cargo> lista);
        List<Cargo> InsertMultiple(List<Cargo> cargos);
    }
}
