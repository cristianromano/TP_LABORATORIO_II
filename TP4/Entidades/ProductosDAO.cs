using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ProductosDAO
    {
        #region Atributos
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion

        #region Constructores
         static ProductosDAO()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-VSLISER\\SQLEXPRESS; Initial Catalog=utnTP4; Integrated Security=True;");
            comando = new SqlCommand();

            comando.Connection = conexion;

            comando.CommandType = CommandType.Text;
        }
        #endregion

        #region Métodos

        #region Getters
        public static List<Producto> ObtieneProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                comando.CommandText = "SELECT * FROM Productos";
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    productos.Add(new Producto(lector["nombre"].ToString(), float.Parse(lector["precio"].ToString()), int.Parse(lector["stock"].ToString()), lector["codigo"].ToString(), int.Parse(lector["id"].ToString())));
                }

                lector.Close();                        
            }

            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
            finally
            {
              conexion.Close();
            }

            return productos;

        }
        #endregion

        #region Insertar Persona
        public static bool InsertaProducto(Producto p)
        {
            string sql = "INSERT INTO Productos(nombre , precio , stock , codigo)" +
                $"VALUES(@nombre,@precio,@stock,@codigo)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("nombre", p.Nombre);
            comando.Parameters.AddWithValue("precio", p.Precio);
            comando.Parameters.AddWithValue("stock", p.Stock);
            comando.Parameters.AddWithValue("codigo", p.Codigo);

            return EjecutarNonQuery(sql);

        }
        #endregion

        #region Modificar Producto
        public static bool ModificarProducto(Producto p)
        {
            string sql = "UPDATE Productos SET nombre = @nombre  , precio = @precio  , stock = @stock , codigo = @codigo where id = @id ";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            comando.Parameters.Add(new SqlParameter("@precio", p.Precio));
            comando.Parameters.Add(new SqlParameter("@stock", p.Stock));
            comando.Parameters.Add(new SqlParameter("@codigo", p.Codigo));
            comando.Parameters.Add(new SqlParameter("@id", p.Id));

            return EjecutarNonQuery(sql);

        }

        #endregion

        #region Eliminar Producto
        public static bool EliminarProducto(Producto p)
        {

            string sql = "DELETE FROM Productos WHERE id = @auxId";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@auxID", p.Id));

            return EjecutarNonQuery(sql);
        }
        #endregion

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductosDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductosDAO.conexion.Open();

                // EJECUTO EL COMMAND
                ProductosDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
              conexion.Close();
            }
            return todoOk;
        }

        #endregion
    }
}
