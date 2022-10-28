using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessComponents.Contracts
{
    public interface IAlumnoRepository<T> where T : class, new()
    {
        //CRUD
        void Insert(T o);

        void Update(T o);

        void Delete(Guid id);

        List<T> GetAll();

        T GetOne(Guid id);

        T GetOneByDNI(int id);

    }
}
