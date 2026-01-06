using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public interface IProductRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); // Get All Products
        T GetById(object Id); // To Get a Particular Product

        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}
