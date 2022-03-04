using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_
{
    public class Ingredientes
    {
        public decimal Cantidad;

        public Insumo Insu {get;set;}

        public Ingredientes(Insumo insu, decimal cantidad)
        {
            Insu = insu;
            Cantidad = cantidad;
        }
        public override string ToString()
        {
            return $"Insumos: {Insu}, Cantidad:{Cantidad}";
        }
    }
}
