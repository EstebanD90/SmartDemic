using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PatenteFamilia.Entity
{
    public class Usuario
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string tipo_usuario { get; set; }
        public string email { get; set; }
        public enum estado { ACTIVO , INACTIVO}
        public DateTime fecha_creacion { get; set; }
        public DateTime ultimo_ingreso { get; set; }





        //public List<FamiliaComponent> accesos = new List<FamiliaComponent>();

        //public Usuario()
        //{
        //    this.id = Guid.NewGuid().ToString();
        //}

        //public Usuario(string nombre, string password)
        //{
        //    id = Guid.NewGuid().ToString();
        //    this.nombre = nombre;
        //    this.password = password;
        //}

        //public List<Patente> GetAllPatentes()
        //{
        //    var patentes = new List<Patente>();
        //    foreach (FamiliaComponent a in this.accesos)
        //    {
        //        if (a.GetType().Name == "Familia")
        //        {
        //            patentes.AddRange(a.GetAccesos());
        //        }
        //        else
        //        {
        //            patentes.Add((Patente)a);
        //        }

        //    }
        //    // distinct
        //    return patentes.GroupBy(x => x.id).Select(x => x.First()).ToList();
        //}
    }
}
