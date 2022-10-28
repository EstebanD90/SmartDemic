using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;


namespace Framework.PatenteFamilia.Data
{
    public class FamiliaFamiliaDAL
    {
        //public static void Insert(string id_familia_padre, string id_familia_hijo)
        //{
        //    var db = Database.Open();
        //    if (!Exists(id_familia_padre, id_familia_hijo))
        //    {
        //        db.Familia_Familias.Insert(id_familia_padre: id_familia_padre, id_familia_hijo: id_familia_hijo);
        //    }
        //}

        //public static void Delete(string id_familia_padre, string id_familia_hijo)
        //{
        //    var db = Database.Open();
        //    db.Familia_Familias.Delete(id_familia_padre: id_familia_padre, id_familia_hijo: id_familia_hijo);
        //}

        //public static bool Exists(string id_familia_padre, string id_familia_hijo)
        //{
        //    var db = Database.Open();
        //    return db.Familia_Familias.Any(db.Familia_Familias.id_familia_padre == id_familia_padre && db.Familia_Familias.id_familia_hijo == id_familia_hijo);
        //}

        //public static void DeleteByFamilia(string id)
        //{
        //    var db = Database.Open();
        //    db.Familia_Familias.Delete(id_familia_padre: id);
        //}

        //public static List<Familia> FindAllByFamilia(string id)
        //{
        //    var db = Database.Open();
        //    return db.Familia_Familias.FindAll(db.Familia_Familias.id_familia_padre == id)
        //        .Join(db.Familia).On(db.Familia.id == db.Familia_Familias.id_familia_hijo)
        //        .Select(db.Familia.nombre, db.Familia.id)
        //        .ToList<Familia>();
        //}
    }
}
