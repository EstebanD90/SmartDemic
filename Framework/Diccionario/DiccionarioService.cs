using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Diccionario
{
    public class DiccionarioService
    {
        ///// Obtiene un diccionario con traducciones hacia el lenguaje pasado por parametro
        ///// <param name="lenguaje">lenguaje a traducir</param>
        //public static Dictionary<string, string> GetDiccionario(string lenguaje)
        //{
        //    var db = Database.Open();
        //    List<Traduccion> traducciones = db.Traduccions.FindAllByLenguaje(lenguaje);
        //    Dictionary<string, string> diccionario = new Dictionary<string, string>();
        //    foreach (Traduccion t in traducciones)
        //    {
        //        diccionario[t.clave] = t.traduccion;
        //    }
        //    return diccionario;
        //}
    }
}
