using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Archivos;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> aux = new List<Producto>();

            try
            {
                aux.Add(new Producto("Milanesa", 70, 47, "GF43F"));
                aux.Add(new Producto("Cerveza", 40, 17, "HF43F"));
                aux.Add(new Producto("Termometro", 30, 67, "KJ43F"));
                aux.Add(new Producto("Libro", 90, 37, "MN43F"));

                bool duda = aux.ListaIsNullorEmpty();              

                if (duda is true)
                {
                    throw new ExcepcionesGenericas("la lista esta vacia :(");
                }

                else
                {
                    Console.WriteLine($"el argumento de que la lista es nula es {duda} , en total hay {aux.conteoLista()} elementos");
                }
            }
            catch (ExcepcionesGenericas e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


        }
    }
}
