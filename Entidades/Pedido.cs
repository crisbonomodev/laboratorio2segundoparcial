using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    [Serializable]
    public class Pedido : IArchivos<Pedido>
    {

        #region Enumerados
        public enum EEstadoPedido
        {
        EnPreparacion,
        Completado
        }

        #endregion
        #region Atributos

        private DateTime fechaYHora;
        private TimeSpan tiempoPreparacion;
        private int nroPedido;
        private string nombreCliente;
        private List<Producto> detallePedido;
        private double totalPedido;
        public EEstadoPedido estadoPedido;
        #endregion
        #region Propiedades

        public int NroPedido
        {
            get { return this.nroPedido; }
            set { nroPedido = value; }
        }
        public string NombreCliente
        {
            get { return this.nombreCliente; }
            set { nombreCliente = value; }
        }
        public double TotalPedido
        {
            get { return totalPedido; }
            set { totalPedido = value; }
        }

        public DateTime FechaYHora
        {
            get
            {
                return fechaYHora;
            }
        }

        public TimeSpan TiempoPreparacion
        {
            get
            {
                return tiempoPreparacion;
            }
            set
            {
                this.tiempoPreparacion = value;
            }
        }

        public List<Producto> DetallePedido
        {
            get 
            {
                return this.detallePedido; }
            set { detallePedido = value; }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Pedido()
        {
            this.nroPedido = BaseDeDatos.ObtenerUltimoPedidoConfirmado() + 1 + Pizzeria.PedidosEnPreparacion.Count;
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombreCliente"></param>
        /// <param name="detallePedido"></param>
        /// <param name="totalPedido"></param>
        public Pedido(string nombreCliente, List<Producto> detallePedido, double totalPedido): this()
        {

            this.fechaYHora = DateTime.Now;
            this.nombreCliente = nombreCliente;
            this.detallePedido = detallePedido;
            this.totalPedido = totalPedido;
            estadoPedido = EEstadoPedido.EnPreparacion;
        }
        /// <summary>
        /// Implementacion del metodo para imprimir ticket del pedido
        /// </summary>
        /// <param name="miPedido"></param>
        void IArchivos<Pedido>.GenerarTicket(Pedido miPedido)
        {
            DateTime fechaHora = new DateTime();
            fechaHora = DateTime.Now;
            StreamWriter sw = File.CreateText($"Ticket Nro{miPedido.NroPedido}.txt");
            sw.WriteLine($"Pizzeria - Recibo X - Pedido Nro{miPedido.NroPedido} ");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"{fechaHora}");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"Cliente: {miPedido.NombreCliente}");
            sw.WriteLine("---------------------------");
            sw.WriteLine("Producto Nro Descripcion Cantidad PrecioU Subtotal");
            foreach (Producto item in miPedido.DetallePedido)
            {
                sw.WriteLine($"{item.IdProducto} {item.NombreProducto}");
            }
            sw.WriteLine("---------------------------");
            sw.Close();
        }

        #endregion
        #region Sobrecarga de operadores

        /// <summary>
        /// Dos pedidos seran iguales si su numero de pedido es el mismo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Pedido a, Pedido b)
        {
            return a.NroPedido == b.nroPedido;
        }

        /// <summary>
        /// /// Dos pedidos seran distintos si su numero de pedido no es el mismo

        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Pedido a, Pedido b)
        {
            return !(a.NroPedido == b.nroPedido);
        }

        #endregion
    }
}
