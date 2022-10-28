using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Bitacora
{
    public class Bitacora
    {
        public enum Severidad { NONE, ERROR, INFO, WARNING }
        public enum TipoLog { USUARIO, SISTEMA }
        public string mensaje { get; set; }
        public DateTime fecha { get; set; }
        public string usuario { get; set; }
        public Severidad severidad { get; set; }
        public TipoLog tipo { get; set; }

        public Bitacora()
        {

        }

        public Bitacora(TipoLog tipo, Severidad severidad, string user, DateTime fecha, string mensaje)
        {
            this.tipo = tipo;
            this.severidad = severidad;
            this.usuario = user;
            this.fecha = fecha;
            this.mensaje = mensaje;
        }
    }
}
