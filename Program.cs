using System;
using Cocina_;

namespace Test_Cocina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Todo");

            Pedido pedido = new Pedido(1, DateTime.Now);
            Insumo insumo = new Insumo("Margarina");
            Insumo insumo1 = new Insumo("MARGARITA", 23);
            Ingredientes ingredientes1 = new Ingredientes(insumo, 25);
            Producto producto = new Producto("margarina", 10);

            Console.WriteLine(pedido);
            Console.WriteLine(insumo);
            Console.WriteLine(insumo1);
            Console.WriteLine(ingredientes1);
            Console.WriteLine(producto);






            
        }
    }
}
