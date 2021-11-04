using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_5
{
    abstract class Vehiculo
    {
        public string marca;
        public string modelo;
        public string color;
        public string patente;
        public int precioBase;


        public Vehiculo()
        {

        }

        public Vehiculo(string ma, string mo, string co, string pa, int precio)
        {
            marca = ma;
            modelo = mo;
            color = co;
            patente = pa;
            precioBase = precio;
            return;
        }

        virtual public void MostrarDatos()
        {
            Console.WriteLine(" - Marca: " + marca);
            Console.WriteLine(" - Modelo: " + modelo);
            Console.WriteLine(" - Color: " + color);
            Console.WriteLine(" - Patente: " + patente);
            Console.WriteLine(" - Precio base: " + precioBase);

        }

        virtual public void calcularPoliza()
        {
            
        }
    }
}
