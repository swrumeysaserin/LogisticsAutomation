using NEURONLOGISTIC.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.BusinessLayer.Concrate
{
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        Context database = new Context();

        public void Delete(T t)
        {
            database.Remove(t);
            database.SaveChanges();
        }

        public List<T> GetAllList()
        {
            return database.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return database.Set<T>().Find(id);
        }

        public T Insert(T t)
        {
            database.Add(t);
            database.SaveChanges();
            return t;
        }

        public T Update(T t)
        {
            database.Update(t);
            database.SaveChanges();
            return t;
        }
    }
}