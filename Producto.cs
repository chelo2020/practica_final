using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_
{
    public class Producto:Articulo
    {
        public decimal MargenUtilidad { get; set; }

        List<Ingredientes> Ingre = new List<Ingredientes> { };

        public Producto(string nombre) : base(nombre) { }

        public Producto(string nombre, decimal margen) : base(nombre)
        {
            MargenUtilidad = margen;
        }
        public void AddIngredientes(Ingredientes ingre)
        {
            Ingre.Add(ingre);
        }

        public decimal Calcular_Precio()
        {
            decimal total=0;

            foreach (var item in Ingre)
            {
                total += item.Insu.Precio + item.Cantidad;
            }

            return total / MargenUtilidad;

        }

        public List<Ingredientes> GetReceta()
        {
            return Ingre;
        }


        public override decimal Precio { get => Calcular_Precio(); }


    }
}
