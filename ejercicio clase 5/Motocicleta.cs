using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_5
{
    class Motocicleta : Vehiculo
    {
        private int cilindrada;
        private int precioAdicionalA;
        private int precioAdicionalB;
       

        public Motocicleta() {
        }

        public Motocicleta(int cilin, string ma, string mo, string co, string pa, int precio) : base(ma, mo, co, pa, precio){ 
            cilindrada = cilin;
            return;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("La cilindradra es de " + cilindrada);
            base.MostrarDatos();
        }

        public override void calcularPoliza()
        {
            precioAdicionalA = precioBase * 5 / 100;
            precioAdicionalB = precioBase * 15 / 100;

            if (cilindrada >= 250 && cilindrada < 750)
            {
                precioBase += precioAdicionalA;

                Console.WriteLine(" - El precio total de póliza de motocicleta con cilindrada 250 cc o más, es de: $" + precioBase);
            }else if (cilindrada >= 250 && cilindrada >= 750 )
            {
                precioBase += precioAdicionalB;
                Console.WriteLine(" - El precio total de póliza de motocicleta con cilindrada 750 cc o más, es de: $" + precioBase);
            } else
            {
                Console.WriteLine(" - El precio total de póliza de motocicleta con cilindrada menor a 250 cc es de: $ " + precioBase);
            }

        }

    }

}
