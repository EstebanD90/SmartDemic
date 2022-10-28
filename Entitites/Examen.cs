using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Examen
    {
        public Guid id { get; set; }
        public string motivo { get; set; }
        public string tipo_examen { get; set; }
        public string materia { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public enum estado { EN_CURSO, FINALIZADO, PENDIENTE }
        public Docente solicitante { get; set; }

        public Examen()
        {
            this.solicitante = new Docente();
        }
    }
}
