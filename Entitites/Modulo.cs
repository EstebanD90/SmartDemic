using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Modulo
    {
        public Guid id { get; set; }
        public char comision { get; set; }
        public int division { get; set; }
        public int curso { get; set; }
        public string modalidad { get; set; }
        public enum estado { EN_CURSO, FINALIZADO, PENDIENTE }
        public PersonalAdministrativo solicitante { get; set; }

        public List<Materia> materias { get; set; }
        public List<Alumno> alumnos { get; set; }
        public List<Docente> docentes { get; set; }

        public Modulo() {
            this.alumnos = new List<Alumno>();
            this.materias = new List<Materia>();
            this.docentes = new List<Docente>();
            this.solicitante = new PersonalAdministrativo();
        }

    }
}
