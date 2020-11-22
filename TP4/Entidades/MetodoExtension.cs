using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public static class MetodoExtension
    {
        /// <summary>
        /// devuelve un false si la lista no es null
        /// </summary>
        /// <param name="auxLista"></param>
        /// <returns></returns>
        public static bool ListaIsNullorEmpty(this List<Producto> auxLista)
        {

            if (auxLista == null || auxLista.Count == 0)
            {
                return true;
            }

            return false;
        }

        public static int conteoLista(this List<Producto> auxLista)
        {
            int contador = 0;

            foreach (Producto item in auxLista)
            {
                if (item != null)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}
