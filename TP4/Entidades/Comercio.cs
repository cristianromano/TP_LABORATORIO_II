using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class Comercio
    {

        static List<Producto> ListaProductos;
        static List<Venta> ListaVentas;
        static List<Producto> ListaAux;

        static Comercio()
        {

            ListaProductos = new List<Producto>();
            ListaVentas = new List<Venta>();
            ListaAux = new List<Producto>();

        }

        public static List<Producto> Productos
        {
            get
            {
                return ProductosDAO.ObtieneProductos();
            }
        }
        public static List<Venta> Ventas { get => ListaVentas; }


        public static bool GuardarXml(List<Producto> productos)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "productos.xml");
            Xml<List<Producto>> dato = new Xml<List<Producto>>();

            return dato.Guardar(path, productos);
        }

        public static List<Producto> LeerXml()
        {
            List<Producto> aux = new List<Producto>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "productos.xml");
            Xml<List<Producto>> xmlProducto = new Xml<List<Producto>>();
            xmlProducto.Leer(path, out aux);

            return aux;

        }
        

    }
}
