using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;

namespace Framework.PatenteFamilia.Data
{
    public static class UsuarioPatenteDAL
    {
        //public static void Insert(string id_usuario, string id_patente)
        //{
        //    var db = Database.Open();
        //    if (!Exists(id_usuario, id_patente))
        //    {
        //        db.Usuario_Patentes.Insert(id_usuario: id_usuario, id_patente: id_patente);
        //    }
        //}

        //public static void Delete(string id_usuario, string id_patente)
        //{
        //    var db = Database.Open();
        //    db.Usuario_Patentes.Delete(id_usuario: id_usuario, id_patente: id_patente);
        //}

        //public static void DeleteByUser(string id_usuario)
        //{
        //    var db = Database.Open();
        //    db.Usuario_Patentes.Delete(id_usuario: id_usuario);
        //}

        //public static bool Exists(string id_usuario, string id_patente)
        //{
        //    var db = Database.Open();
        //    return db.Usuario_Patentes.Any(db.Usuario_Patentes.id_usuario == id_usuario && db.Usuario_Patentes.id_patente == id_patente);
        //}

        //public static List<Patente> FindAllByUsuario(string id)
        //{
        //    var db = Database.Open();
        //    return db.Usuario_Patentes.FindAll(db.Usuario_Patentes.id_usuario == id)
        //        .Join(db.Patente).On(db.Patente.id == db.Usuario_Patentes.id_patente)
        //        .Select(db.Patente.nombre, db.Patente.id)
        //        .ToList<Patente>();
        //}
    }
}
