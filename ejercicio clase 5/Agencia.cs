using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_5
{
    class Agencia
    {
        static void Main(string[] args)
        {
            //Motocicletas
            Motocicleta m1 = new Motocicleta(210, "Ducati", "B-165", "Azul", "GHT-542", 1045000);
            Motocicleta m2 = new Motocicleta(790, "Ducati", "A-105", "Rojo", "POU-723", 1900000);
            Motocicleta m3 = new Motocicleta(255, "Ducati", "C-150", "Naranja", "EYW-985", 1050000);



            Console.WriteLine("———————————————————————————————————————————————");
            Console.WriteLine("############# - MOTOCICLETAS - #############");
            Console.WriteLine("———————————————————————————————————————————————");
            
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Motocicleta 1: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            m1.MostrarDatos(); // Aquí se imprimen los datos de las motocicletas
            Console.WriteLine("=========================================================================================");
            m1.calcularPoliza(); // Aquí se imprime el precio total dependiendo de la cilindrada de la moto
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine(">  Motocileta 2: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            m2.MostrarDatos(); // Aquí se imprimen los datos de las motocicletas
            Console.WriteLine("=========================================================================================");
            m2.calcularPoliza();  // Aquí se imprime el precio total dependiendo de la cilindrada de la moto
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Motocicleta 3: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            m3.MostrarDatos(); // Aquí se imprimen los datos de las motocicletas
            Console.WriteLine("=========================================================================================");
            m2.calcularPoliza(); // Aquí se imprime el precio total dependiendo de la cilindrada de la moto
            Console.WriteLine("=========================================================================================");


            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////");

            //Automóviles
            Automotor a1 = new Automotor("Nafta", 6, false, "Renault", "Duster", "Verde Musgo", "DVV-645", 1500000);
            Automotor a2 = new Automotor("Gas", 6, true, "Ford", "Fiesta", "Gris", "LFI-787", 1100000);
            
            
            Console.WriteLine("———————————————————————————————————————————————");
            Console.WriteLine("############# - AUTOMOTORES - #############");
            Console.WriteLine("———————————————————————————————————————————————");
            
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Automóvil 1: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            a1.MostrarDatos(); // Aquí se imprimen los datos de los automóviles
            Console.WriteLine("=========================================================================================");
            a1.calcularPoliza(); // Aquí se imprime el precio total con o sin adicional por el GNC
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Automóvil 2: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            a2.MostrarDatos(); // Aquí se imprimen los datos de los automóviles
            Console.WriteLine("=========================================================================================");
            a2.calcularPoliza(); // Aquí se imprime el precio total con o sin adicional por el GNC
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////");

            //Embarcaciones
            Embarcaciones b1 = new Embarcaciones(1, true, 16.11, "Prestige", "F-line 520", "Blanco", "7-VA-2-808-15", 5000000);
            Embarcaciones b2 = new Embarcaciones(2, false, 13.00, "Adventure", "AA-line 5241", "Blanco", "87-KJ-007-30", 5000000);
            Embarcaciones b3 = new Embarcaciones(3, false, 20.05, "Elegant", "TWE-line 77", "Azul marino", "3-WQ-0-000-08", 5000000);
            Embarcaciones b4 = new Embarcaciones(4, false, 20.05, "Elegant", "TWE-line 77", "Azul marino", "3-WQ-0-000-08", 5000000);
            Embarcaciones b5 = new Embarcaciones(0, false, 6.5, "KAYAK", "K.2", "Verde", "08889536G", 5000000);
            
            
            Console.WriteLine("———————————————————————————————————————————————");
            Console.WriteLine("############# - EMBARCACIONES - #############");
            Console.WriteLine("———————————————————————————————————————————————");
            Console.WriteLine();
            
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Embarcación 1: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            b1.MostrarDatos(); // Aquí se imprimen los datos de la embarcación
            Console.WriteLine("=========================================================================================");
            b1.calcularPoliza(); // Aquí se imprime el precio total de póliza, dependiendo de cantidad de propulsores
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Embarcación 2: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            b2.MostrarDatos(); // Aquí se imprimen los datos de la embarcación
            Console.WriteLine("=========================================================================================");
            b2.calcularPoliza(); // Aquí se imprime el precio total de póliza, dependiendo de cantidad de propulsores
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Embarcación 3: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            b3.MostrarDatos(); // Aquí se imprimen los datos de la embarcación
            Console.WriteLine("=========================================================================================");
            b3.calcularPoliza(); // Aquí se imprime el precio total de póliza, dependiendo de cantidad de propulsores
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Embarcación 4: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            b4.MostrarDatos(); // Aquí se imprimen los datos de la embarcación
            Console.WriteLine("=========================================================================================");
            b4.calcularPoliza(); // Aquí se imprime el precio total de póliza, dependiendo de cantidad de propulsores
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("> Embarcación 5: <");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            b5.MostrarDatos(); // Aquí se imprimen los datos de la embarcación
            Console.WriteLine("=========================================================================================");
            b5.calcularPoliza(); // Aquí se imprime el precio total de póliza, dependiendo de cantidad de propulsores
            Console.WriteLine("=========================================================================================");
           
            Console.ReadKey();
        }
    }
}
