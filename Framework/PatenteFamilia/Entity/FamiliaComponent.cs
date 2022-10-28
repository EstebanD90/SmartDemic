using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PatenteFamilia.Entity
{
    public abstract class FamiliaComponent
    {
        public abstract void Agregar(FamiliaComponent c);
        public abstract void Remover(FamiliaComponent c);

        public abstract List<Patente> GetAccesos();

        public string nombre { get; set; }
        public string id { get; set; }

        public FamiliaComponent()
        {
            this.id = Guid.NewGuid().ToString();
        }

    }
}
