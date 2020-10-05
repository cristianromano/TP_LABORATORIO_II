using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            // Nombre del alumno
            Console.Title = "Cristian A. Romano Wybranski";

            Taller taller = new Taller(6);

            Ciclomotor c1 = new Ciclomotor( "ASD012" ,EMarca.BMW, ConsoleColor.Black);
            Ciclomotor c2 = new Ciclomotor("LEM666" , EMarca.HarleyDavidson,  ConsoleColor.Red);
            Sedan m1 = new Sedan("HJK789",EMarca.Toyota, ConsoleColor.White,Sedan.ETipo.CincoPuertas);
            Sedan m2 = new Sedan("IOP852",EMarca.Chevrolet, ConsoleColor.Blue,Sedan.ETipo.CincoPuertas);
            Suv a1 = new Suv("QWE968",EMarca.Ford, ConsoleColor.Gray);
            Suv a2 = new Suv("TYU426",EMarca.Renault, ConsoleColor.DarkBlue);
            Suv a3 = new Suv("IOP852",EMarca.BMW, ConsoleColor.Green);
            Suv a4 = new Suv("ASD913",EMarca.Honda, ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            taller += c1;
            taller += c2;
            taller += m1;
            taller += m1;
            taller += m2;
            taller += a1;
            taller += a2;
            taller += a3;
            taller += a4;

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Quito 2 items y muestro
            taller -= c1;
            taller -= new Ciclomotor("ASD913", EMarca.Honda ,ConsoleColor.Red);

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Vuelvo a agregar c2
            taller += c2;

            // Muestro solo Moto
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Moto));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Automovil
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Automovil));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Camioneta
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Camioneta));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();
        }
    }
}
