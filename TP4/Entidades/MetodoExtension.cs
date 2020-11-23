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

        public static string StockeoString(this Venta v)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"------------------------------");
            sb.AppendLine("------TICKET DE STOCKEO---------");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Hora: {DateTime.Now.ToString("G")}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Productos STOCKEADOS x listado ");
            sb.AppendLine($"------------------------------");

            foreach (Producto item in v.Productos)
            {
                sb.AppendLine($"Item: {item.Nombre} x Precio: {item.Precio} [CANTIDAD: {item.Stock}]");
                sb.AppendLine($"------------------------------");
            }

            sb.AppendLine($"Precio Final: ${v.Monto}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"GRACIAS POR TU COMPRA - TICKET N*{v.Ticket}");

            return sb.ToString();
        }


    }
}
