using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;


namespace Framework.PatenteFamilia.Data
{
    public static class UsuarioFamiliaDAL
    {
        //public static void Insert(string id_usuario, string id_familia)
        //{
        //    var db = Database.Open();
        //    if (!Exists(id_usuario, id_familia))
        //    {
        //        db.Usuario_Familias.Insert(id_usuario: id_usuario, id_familia: id_familia);
        //    }
        //}

        //public static void Delete(string id_usuario, string id_familia)
        //{
        //    var db = Database.Open();
        //    db.Usuario_Familias.Delete(id_usuario: id_usuario, id_familia: id_familia);
        //}

        //public static void DeleteByUser(string id_usuario)
        //{
        //    var db = Database.Open();
        //    db.Usuario_Familias.Delete(id_usuario: id_usuario);
        //}

        //public static bool Exists(string id_usuario, string id_familia)
        //{
        //    var db = Database.Open();
        //    return db.Usuario_Familias.Any(db.Usuario_Familias.id_usuario == id_usuario && db.Usuario_Familias.id_familia == id_familia);
        //}

        //public static List<Familia> FindAllByUsuario(string id)
        //{
        //    var db = Database.Open();
        //    return db.Usuario_Familias.FindAll(db.Usuario_Familias.id_usuario == id)
        //        .Join(db.Familia).On(db.Familia.id == db.Usuario_Familias.id_familia)
        //        .Select(db.Familia.nombre, db.Familia.id)
        //        .ToList<Familia>();
        //}
    }
}
