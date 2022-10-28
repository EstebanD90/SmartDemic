using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Bitacora
{
    public class BitacoraDAL
    {
        //internal static void Write(Bitacora bitacora)
        //{
        //    var db = Database.Open();
        //    db.Bitacoras.Insert(bitacora);
        //}

        //internal static List<Bitacora> GetBy(Bitacora bitacora)
        //{
        //    var db = Database.Open();
        //    if (bitacora.usuario != null && bitacora.severidad != Bitacora.Severidad.NONE)
        //    {
        //        return db.Bitacoras.FindAll(db.Bitacoras.tipo == bitacora.tipo && db.Bitacoras.severidad == bitacora.severidad && db.Bitacoras.usuario == bitacora.usuario && db.Bitacoras.fecha >= bitacora.fecha);
        //    }
        //    else if (bitacora.usuario != null)
        //    {
        //        return db.Bitacoras.FindAll(db.Bitacoras.tipo == bitacora.tipo && db.Bitacoras.usuario == bitacora.usuario && db.Bitacoras.fecha >= bitacora.fecha);
        //    }
        //    else if (bitacora.severidad != Bitacora.Severidad.NONE)
        //    {
        //        return db.Bitacoras.FindAll(db.Bitacoras.tipo == bitacora.tipo && db.Bitacoras.severidad == bitacora.severidad && db.Bitacoras.fecha >= bitacora.fecha);
        //    }
        //    else
        //    {
        //        return db.Bitacoras.FindAll(db.Bitacoras.tipo == bitacora.tipo && db.Bitacoras.fecha >= bitacora.fecha);
        //    }

        //}
    }
}
