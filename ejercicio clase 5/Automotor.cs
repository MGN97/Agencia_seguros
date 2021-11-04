using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_5
{
    class Automotor: Vehiculo
    {
        private string combustible;
        private int cant_puertas;
        private bool gnc;
        private int precioAdicional;


        public Automotor()
        {
        }

        public Automotor(string combustible, int cant_puertas, bool gnc, string ma, string mo, string co, string pa, int precio) : base(ma, mo, co, pa, precio)
        {
            this.combustible = combustible;
            this.cant_puertas = cant_puertas;
            this.gnc = gnc;
            return;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine(" - Combustible: " + combustible);
            Console.WriteLine(" - Cantidad de puertas: " + cant_puertas);
            Console.WriteLine(" - Tiene GNC: " + gnc);
            base.MostrarDatos();
        }

        public override void calcularPoliza()
        {
            precioAdicional = precioBase * 10 / 100;
            if (gnc == true)
            {
                precioBase += precioAdicional;
                
                Console.WriteLine(" - El precio total de la póliza de automotor con GNC es de: $" + precioBase);
            } else
            {
                Console.WriteLine(" - El precio total de la póliza es: $" + precioBase);
            }
            
        }

    }
}
