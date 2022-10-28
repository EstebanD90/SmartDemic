using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Alumno
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public enum tipo_documento { DNI, LE, CI }
        public int nro_documento { get; set; }
        public int telefono { get; set; }
        public string domicilio { get; set; }
        public string localidad { get; set; }
        public string email { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string estado { get; set; }
    }
}
