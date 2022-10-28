using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Inventario
    {
        public Guid id { get; set; }
        public double presupuesto { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public enum estado { EN_CURSO, FINALIZADO, PENDIENTE }
        public PersonalAdministrativo solicitante { get; set; }

        public Inventario()
        {
            this.solicitante = new PersonalAdministrativo();
        }
    }
}
