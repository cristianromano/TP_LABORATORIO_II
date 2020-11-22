using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Entidades
{
    public sealed class Producto
    {
        int id;
        string nombre;
        string codigo;
        float precio;
        int stock;

        #region Constructores

        public Producto()
        {

        }
        public Producto(string nombre, float precio, int stock, string codigo) : this()
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public Producto(string nombre, float precio, int stock, string codigo, int id) : this(nombre, precio, stock, codigo)
        {
            this.Id = id;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        #endregion

        #region Operadores
        /// <summary>
        /// funcion utilizada para verificar si el objeto pasado por parametro ya tiene el mismo codigo que alguno perteneciente a la lista , de ser asi devuelve un true
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator ==(List<Producto> productos, Producto producto)
        {
            bool retorno = false;

            foreach (Producto item in productos)
            {
                if (item.Codigo == producto.codigo)
                {
                    retorno = true;
                    break;

                }
            }

            return retorno;
        }

        /// <summary>
        /// niega el metodo ==
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

        /// <summary>
        /// agrega un nuevo producto a la base de datos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Producto> productos, Producto producto)
        {
            bool retorno = false;

            if (productos != producto)
            {
                producto.Guardar();
                retorno = true;
            }

            else
            {
                foreach (Producto item in productos)
                {
                    if(item.codigo == producto.codigo)
                    {
                        item.Stock += producto.Stock;
                        item.Modificar();
                    }                  

                }
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// elimina un producto de la base de datos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<Producto> productos, Producto producto)
        {
            bool retorno = false;

            foreach (Producto item in productos)
            {
                if (item.id == producto.id)
                {
                    producto.Eliminar();
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// guardo en la base de datos el producto
        /// </summary>
        /// <returns>producto</returns>
        public bool Guardar()
        {
            return ProductosDAO.InsertaProducto(this);
        }

        /// <summary>
        /// elimino de la base de datos el producto
        /// </summary>
        /// <returns>producto</returns>
        public bool Eliminar()
        {
            return ProductosDAO.EliminarProducto(this);
        }

        /// <summary>
        /// modifico en la base de datos el producto
        /// </summary>
        /// <returns>producto</returns>
        public bool Modificar()
        {
            return ProductosDAO.ModificarProducto(this);
        }

        /// <summary>
        /// funcion creada para el descuento del stock de una venta
        /// </summary>
        /// <param name="p"></param>
        /// <returns>modifica una lista de productos</returns>
        public static bool ModificarLista(List<Producto> p)
        {
            bool retorno = false;

            foreach (Producto item in p)
            {
                ProductosDAO.ModificarProducto(item);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// agrego una lista de productos a la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>lista productos</returns>
        public static bool AgregarLista(List<Producto> p)
        {
            bool retorno = false;

            foreach (Producto item in p)
            {
                ProductosDAO.ModificarProducto(item);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// override del metodo toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {Nombre} ");
            sb.AppendLine($"CODIGO: {Codigo} ");
            sb.AppendLine($"PRECIO: {Precio} ");
            sb.AppendLine($"STOCK AGREGADO: {Stock} ");
            sb.AppendLine($"ID: {Id} ");

            return sb.ToString();
        }

        #endregion

    }

}
