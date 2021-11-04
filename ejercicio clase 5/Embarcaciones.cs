using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_5
{
    class Embarcaciones: Vehiculo
    {
        private int cantidadMotores = 0;
        private bool a_bela;
        private double eslora;
        private int precioAdicional;

        public Embarcaciones()
        {
        }

        public Embarcaciones(int cantidadMotores, bool a_bela, double eslora, string ma, string mo, string co, string pa, int precio) : base(ma, mo, co, pa, precio)
        {
            this.cantidadMotores = cantidadMotores;
            this.a_bela = a_bela;
            this.eslora = eslora;
            return;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Cantidad motores: " + cantidadMotores);
            Console.WriteLine("Es a vela: " + a_bela);
            Console.WriteLine("Eslora de: " + eslora + "m");
            base.MostrarDatos();
        }

        public override void calcularPoliza()
        {
            precioAdicional = precioBase * 3 / 100;

            if (cantidadMotores == 1)
            {
                precioBase += precioAdicional;
                Console.WriteLine("Precio total de póliza para embarcación con 1 propulsor: $" + precioBase);
            }
            else if (cantidadMotores >= 1 && cantidadMotores <= 2)
            {
                precioAdicional *= 2;
                precioBase += precioAdicional;
                Console.WriteLine("Precio total de póliza para embarcación con 2 propulsores: $" + precioBase);
            }
            else if (cantidadMotores >= 1 && cantidadMotores <= 3)
            {
                precioAdicional *= 3;
                precioBase += precioAdicional;
                Console.WriteLine("Precio total de póliza para embarcación con 3 propulsores: $" + precioBase);
            }
            else if (cantidadMotores >= 1 && cantidadMotores <= 4)
            {
                precioAdicional *= 4;
                precioBase += precioAdicional;
                Console.WriteLine("Precio total de póliza para embarcación con 4 propulsores: $" + precioBase);
            }
            else
            {
                Console.WriteLine("Precio total de póliza para embarcación sin propulsor: $" + precioBase);

            }

        }

    }
}
