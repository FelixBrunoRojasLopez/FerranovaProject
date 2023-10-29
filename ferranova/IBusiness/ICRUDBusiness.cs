﻿using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    /// <summary>
    /// DECLARA LOS METODOS DEL CRUD 
    /// </summary>
    /// <typeparam name="T">REQUEST</typeparam>
    /// <typeparam name="Y">RESPONSE</typeparam>
    public interface ICRUDBusiness<T, Y> : IDisposable
    {
        List<Y> GetAll();
        Y GetById(int id);
        Y Create(T entity);
        Y Update(T entity);
        int Delete(int id);
        int DeleteMultipleItems(List<T> lista);
        List<Y> InsertMultiple(List<T> lista);
        List<Y> UpdateMultiple(List<T> lista);
    }

}
