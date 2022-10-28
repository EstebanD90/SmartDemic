using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;


namespace Framework.PatenteFamilia.Data
{
    public static class FamiliaPatenteDAL
    {
        //public static void Insert(string id_familia, string id_patente)
        //{
        //    var db = Database.Open();
        //    if (!Exists(id_familia, id_patente))
        //    {
        //        db.Familia_Patentes.Insert(id_familia: id_familia, id_patente: id_patente);
        //    }

        //}

        //public static void Delete(string id_familia, string id_patente)
        //{
        //    var db = Database.Open();
        //    db.Familia_Patentes.Delete(id_familia: id_familia, id_patente: id_patente);
        //}

        //public static bool Exists(string id_familia, string id_patente)
        //{
        //    var db = Database.Open();
        //    return db.Familia_Patentes.Any(db.Familia_Patentes.id_familia == id_familia && db.Familia_Patentes.id_patente == id_patente);
        //}

        //public static void DeleteByFamilia(string id)
        //{
        //    var db = Database.Open();
        //    db.Familia_Patentes.Delete(id_familia: id);
        //}

        //public static List<Patente> FindAllByFamilia(string id)
        //{
        //    var db = Database.Open();
        //    return db.Familia_Patentes.FindAll(db.Familia_Patentes.id_familia == id)
        //        .Join(db.Patente).On(db.Patente.id == db.Familia_Patentes.id_patente)
        //        .Select(db.Patente.nombre, db.Patente.id)
        //        .ToList<Patente>();
        //}
    }
}
