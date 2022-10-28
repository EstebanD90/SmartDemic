using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitites;
using DataAccessComponents.Contracts;
using DataAccessComponents.Repositories;
using System.Configuration;


namespace DataAccessComponents.Factories
{
	public static class Factory
	{

		//public static IGenericRepository<Alumno> GetAlumnoRepository()
		//{

		//	return (IGenericRepository<Alumno>)AlumnoRepository.Current;
		//}


        readonly static string repository;
        public static IGenericRepository<Alumno> AlumnoRepository { get; set; }
        static Factory()
        {
            repository = ConfigurationManager.AppSettings["Repository"].ToString();

            //Creo los repositorios
            AlumnoRepository = (IGenericRepository<Alumno>)Activator.CreateInstance
                                                    (Type.GetType(repository + ".AlumnoRepository"));
        }
    }
}
