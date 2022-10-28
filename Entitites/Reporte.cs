using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Reporte
    {
        public Guid id { get; set; }
        public string motivo { get; set; }
        public enum tipo_reporte { CONTROL_ASISTENCIAS, SUELDO_DOCENTE, HORAS_DOCENTE, CONTROL_CALIFICACIONES, MATERIALES_INVENTARIO}
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public enum estado { EN_CURSO, FINALIZADO, PENDIENTE }
        public PersonalAdministrativo solicitante { get; set; }

        public Reporte()
        {
            this.solicitante = new PersonalAdministrativo();
        }
    }
}
