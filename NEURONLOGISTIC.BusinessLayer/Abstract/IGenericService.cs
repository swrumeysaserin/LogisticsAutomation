using NEURONLOGISTIC.BusinessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        T Insert(T t);
        void Delete(T t);
        T Update(T t);
        List<T> GetAllList();
        T GetById(int id);
    }
}