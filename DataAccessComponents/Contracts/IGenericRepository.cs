using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitites;

namespace DataAccessComponents.Contracts
{
    public interface IGenericRepository<T> //where T : class, new()
    {
        //CRUD
        void Insert(T obj);

        void Update(T obj);

        void Delete(Guid id);

        List<T> GetAll();

        T GetOne(Guid id);

        T GetOneByDNI(int id);
    }
}
