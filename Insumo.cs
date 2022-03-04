using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_
{
    public class Insumo:Articulo
    {
        public override decimal Precio { get => _precio; }
        public Insumo(string nombre) : base(nombre) { }

        public Insumo(string nombre,decimal precio) : base(nombre) {
            _precio = precio;
        }

        public void SetPrecio(decimal valor)
        {
            _precio = valor;
        }
    }
}
