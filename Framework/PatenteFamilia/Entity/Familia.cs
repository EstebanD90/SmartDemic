using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PatenteFamilia.Entity
{
    public class Familia : FamiliaComponent
    {
        public List<FamiliaComponent> accesos { get; set; }
        public Familia()
        {
            this.accesos = new List<FamiliaComponent>();
        }
        public Familia(string nombre)
        {
            this.nombre = nombre;
            this.accesos = new List<FamiliaComponent>();
        }

        public override void Agregar(FamiliaComponent c)
        {
            accesos.Add(c);
        }

        public override void Remover(FamiliaComponent c)
        {
            accesos.RemoveAll(component => component.nombre == c.nombre);
        }

        public override List<Patente> GetAccesos()
        {
            var patentes = new List<Patente>();
            foreach (var a in accesos)
            {
                if (a.GetType().Name == "Familia")
                {
                    patentes.AddRange(a.GetAccesos());
                }
                else
                {
                    patentes.Add((Patente)a);
                }

            }
            return patentes;
        }
    }
}
