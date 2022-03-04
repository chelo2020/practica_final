using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_
{
    public class Pedido
    {
        public uint _id { get; set; }

        public DateTime Fecha { get; set; }

        List<Articulo> Art = new List<Articulo> { };

        List<int> Cantidad = new List<int> { };

        public Pedido(uint id, DateTime fecha){

            _id = id;
            Fecha = fecha;
        }
        public void AddArticulo(Articulo art, int cantidad)
        {
            Art.Add(art);
            Cantidad.Add(cantidad);
        }
        public decimal GetPrecioTotal()
        {
            decimal total = 0;

            for (int i = 0; i <Art.Count(); i++)
            {
                total += Art.ElementAt(i).Precio * Cantidad.ElementAt(i);
            }

            return total;
        }
        public override string ToString()
        {
            return $"ID: {_id}, Fecha: {Fecha}";
        }

    }
}
