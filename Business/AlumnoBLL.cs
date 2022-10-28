using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitites;
using DataAccessComponents.Contracts;
using DataAccessComponents.Factories;
using DataAccessComponents.Repositories;


namespace Business
{
    public class AlumnoBLL
    {
        #region Singleton
        private readonly static AlumnoBLL _instance = new AlumnoBLL();
        private readonly static IGenericRepository<Alumno> alumnoDAO = Factory.AlumnoRepository;
        public static AlumnoBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private AlumnoBLL()
        {
            //Implement here the initialization code
        }
        #endregion

        public void Insert(Alumno alumno)
        {
            //Factory.AlumnoRepository.Insert(alumno);
            try
            {
                alumno.id = Guid.NewGuid();

                alumnoDAO.Insert(alumno);

                ///manejar con un IF y excepciones //

                //return alumno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Alumno> GetAll()
        {
            //return Factory.AlumnoRepository.GetAll();

            return alumnoDAO.GetAll();
        }


        public static void Update(Alumno alumno)
        {
            alumnoDAO.Update(alumno);
        }

        //public static void Delete(int id)
        //{
        //    AlumnoDAL.Delete(id);
        //}

        public Alumno GetById(Guid id)
        {
            return alumnoDAO.GetOne(id);
        }

        public Alumno GetByDni(int dni)
        {
            return alumnoDAO.GetOneByDNI(dni);
        }
    }
}
