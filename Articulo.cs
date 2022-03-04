using System;

namespace Cocina_
{
    public abstract class Articulo
    {
        public string Nombre { get; set; }

        protected decimal _precio;

        public abstract decimal Precio { get; }

        public Articulo(string nombre)
        {
            Nombre = nombre;
            Nombre.ToUpper();
        }
        public Articulo(string nombre, decimal precio)
        {
            Nombre = nombre;
            _precio = precio;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }



    }
}
