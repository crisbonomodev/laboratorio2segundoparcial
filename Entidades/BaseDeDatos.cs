using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    
    public static class BaseDeDatos
    {
        #region atributos

        static string path = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Pizzeria;Integrated Security=True;";
        #endregion
        #region Metodos

        /// <summary>
        /// Metodo que devuelve las categorias de productos
        /// </summary>
        /// <returns></returns>
        public static List<Producto> ConsultarCategorias()
        {
            List<Producto> categorias = new List<Producto>();
            SqlConnection conexion = new SqlConnection(path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM dbo.categoria";
            try
            {
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(new Producto((int)reader["idCategoria"], reader["nombre"].ToString()));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally 
            {
                conexion.Close();
            }
            return categorias;

        }
        /// <summary>
        /// Metodo que se conecta a la BD y retorna la lista de productos.
        /// </summary>
        /// <returns></returns>
        public static List<Producto> ConsultarProductos()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            SqlConnection conexion = new SqlConnection(path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM dbo.producto";
            try
            {
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaDeProductos.Add(new Producto((int)reader["idProducto"], (int)reader["idCategoria"], reader["nombreProducto"].ToString()));
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            conexion.Close();
            }
            return listaDeProductos;

        }

        /// <summary>
        /// Metodo que devuelve el ultimo ID de pedido entregado y cobrado
        /// </summary>
        /// <returns></returns>
        public static int ObtenerUltimoPedidoConfirmado()
        {
                int ultimoPedido = 0;
                SqlConnection conexion = new SqlConnection(path);
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM dbo.pedidosEntregados";
            try
            {
                conexion.Open();
                ultimoPedido = (int)comando.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally 
            {
                conexion.Close();   
            }
            return ultimoPedido;
        }

        /// <summary>
        /// Metodo que guarda los pedidos entregados en BD
        /// </summary>
        /// <param name="pedidoAGuardar"></param>
        /// <returns></returns>
        public static void GuardarPedido(Pedido pedidoAGuardar)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(path);
                SqlCommand comando = new SqlCommand();
                SqlCommand comando2 = new SqlCommand();
                comando.Connection = conexion;
                comando2.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando2.CommandType = CommandType.Text;
                conexion.Open();
                comando.CommandText = $"INSERT INTO [dbo].[pedidosEntregados]([idPedido],[nombreClisnte],[total])  VALUES" +
               $" ({pedidoAGuardar.NroPedido},'{pedidoAGuardar.NombreCliente}',{pedidoAGuardar.TotalPedido})";
                comando.ExecuteNonQuery();

                foreach (Producto item in pedidoAGuardar.DetallePedido)
                {
                    comando2.CommandText = $"INSERT INTO [dbo].[detallePedido] ([idPedido],[idProducto],[cantidad],[subtotal])" +
                     $" VALUES({pedidoAGuardar.NroPedido}, {item.IdProducto}, 1, 200)";

                    comando2.ExecuteNonQuery();

                }
                conexion.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
        #endregion
    }
   
}
