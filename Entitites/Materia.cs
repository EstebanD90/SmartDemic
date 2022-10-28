using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Materia
    {
        public Guid id { get; set; }
        public string descripcion { get; set; }
        public double horas_catedra { get; set; }
        public string modalidad { get; set; }
        public double nota_aprobacion { get; set; }
        public enum estado { EN_CURSO, FINALIZADO, PENDIENTE }
    }
}
