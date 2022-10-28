using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PatenteFamilia.Entity
{
    public class Patente : FamiliaComponent
    {
        public Patente(string nombre)
        {
            this.nombre = nombre;
        }

        public Patente()
        {

        }

        public override List<Patente> GetAccesos()
        {
            throw new NotImplementedException();
        }

        public override void Agregar(FamiliaComponent c)
        {
            throw new NotImplementedException();
        }

        public override void Remover(FamiliaComponent c)
        {
            throw new NotImplementedException();
        }

    }
}
