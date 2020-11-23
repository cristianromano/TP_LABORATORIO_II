using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public enum EMedioPago
    {
        Tarjeta,
        Efectivo,
        Fiado
    }
    public sealed class Venta
    {   

        float monto;
        int TicketVentaNumero;
        static int auto = 9814;
        List<Producto> productos;
        EMedioPago pago;

        #region Constructores
        public Venta(float monto , List<Producto> productos)
        {
            this.Monto = monto;
            this.Ticket = auto++;
            this.Productos = productos;
            productos = new List<Producto>();
        }

        public Venta(float monto, List<Producto> productos , EMedioPago pago):this(monto , productos)
        {
            this.Pago = pago;
        }
        #endregion

        #region Propiedades

        public List<Producto> Productos { get => productos; set => productos = value; }
        public float Monto { get => monto; set => monto = value; }
        public int Ticket { get => TicketVentaNumero; set => TicketVentaNumero = value; }
        private EMedioPago Pago { get => pago; set => pago = value; }
        #endregion

        #region Operadores
        /// <summary>
        /// agrega una nueva venta a la lista
        /// </summary>
        /// <param name="ventas"></param>
        /// <param name="venta"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Venta> ventas , Venta venta)
        {
            ventas.Add(venta);
            return true;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// guardo la venta que realizo de manera manual
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public static bool GuardarTexto(Venta venta)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "TICKET VENTA");
            Texto txt = new Texto();
            return txt.Guardar(path, venta.ToString());
        }

        /// <summary>
        /// guarda la venta que se realiza de manera online con hilos
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public static bool GuardarTextoOnline(Venta venta)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "TICKET VENTA ONLINE");
            Texto txt = new Texto();
            return txt.Guardar(path, venta.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public static bool GuardarTextoStock(Venta venta)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "TICKET VENTA STOCK");
            Texto txt = new Texto();
            return txt.Guardar(path, venta.StockeoString());
        }

        /// <summary>
        /// override del metodo toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"------------------------------");
            sb.AppendLine("------TICKET DE COMPRA---------");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Hora: {DateTime.Now.ToString("G")}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Productos vendidos x listado ");
            sb.AppendLine($"------------------------------");

            foreach (Producto item in productos)
            {
                sb.AppendLine($"Item: {item.Nombre} x Precio: {item.Precio}");
                sb.AppendLine($"------------------------------");
            }

            sb.AppendLine($"Precio Final: ${Monto}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"GRACIAS POR TU COMPRA - TICKET N*{Ticket}");

            return sb.ToString();
        }

        #endregion
    }

}
