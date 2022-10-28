using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitites;


namespace DataAccessComponents
{
    public class AlumnoDAL
    {
        //public static Alumno GetByDni(int dni)
        //{
        //    var db = Database.Open();
        //    return db.Alumnos.Find(db.Alumnos.nro_documento == dni);
        //}

        //public static Alumno Insert(Alumno alumno)
        //{
        //    var db = Database.Open();
        //    return db.Alumnos.Insert(alumno);
        //}

        //public static bool Exists(Alumno alumno)
        //{
        //    var db = Database.Open();
        //    return db.Alumnos.Any(db.Alumnos.nro_documento == alumno.nro_documento);
        //}

        //public static void Delete(int dni)
        //{
        //    var db = Database.Open();
        //    db.Alumnos.Delete(nro_documento: dni);
        //}

        //public static void Update(Alumno alumno)
        //{
        //    var db = Database.Open();
        //    db.Alumnos.UpdateAll(nombre: alumno.nombre, apellido: alumno.apellido, email: alumno.email, telefono: alumno.telefono, domicilio: alumno.domicilio, localidad: alumno.localidad, fecha_nacimiento: alumno.fecha_nacimiento, fecha_ingreso: alumno.fecha_ingreso, Condition: db.Alumnos.nro_documento == alumno.nro_documento);
        //}

        //public static List<Alumno> GetAll()
        //{
        //    var db = Database.Open();
        //    return db.vw_Alumnos.All();
        //    //return db.Alumnos.All();
        //    //List<Alumno> result = db.Alumnos.All().Select(db.Alumnos.nro_documento.Distinct()).ToList<Alumno>();
        //    //return result.Select(x => x.nro_documento).ToList();
        //    //return db.Alumnos.GetAll;
        //}

        //public static List<Alumno> GetAllBy(Alumno alumno)
        //{
        //    var db = Database.Open();
        //    return db.Alumnos.FindAll(db.Alumnos.id == alumno.id || db.Alumnos.nombre.Like("%" + alumno.nombre + "%"));
        //}

        //public static Alumno GetById(int id)
        //{
        //    var db = Database.Open();
        //    return db.Alumnos.Find(db.Alumnos.id == id);
        //}
    }
}
