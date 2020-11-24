using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Entidades
{
    public delegate void Transaccion();
    public static class Pizzeria
    {
        public static event Transaccion entregarPedidos;
        static Queue<Pedido> pedidosEnPreparacion;
        static List<Envio> enviosCompletados;
        static List<Pedido> pedidosCompletados;
        static List<Producto> carritoProductos;

        public static List<Producto> CarritoProductos
        {
            get
            {
                return carritoProductos;
            }
        }

        private static int contadorPedidos = 1;

        public static int ContadorPedidos
        {
            get { return contadorPedidos ; }
            set { contadorPedidos = value; }
        }

        public static List<Envio> EnviosCompletados
        {
            get
            {
                return enviosCompletados;
            }
        }

        public static Queue<Pedido> PedidosEnPreparacion
        {
            get
            {
                return pedidosEnPreparacion;
            }
            set
            {
                pedidosEnPreparacion = value;
            }
        }

        public static List<Pedido> PedidosCompletados
        {
            get
            {
                return pedidosCompletados;
            }
        }

        static Pizzeria()
        {
            carritoProductos = new List<Producto>();
            pedidosEnPreparacion = new Queue<Pedido>();
            pedidosCompletados = new List<Pedido>();
            enviosCompletados = new List<Envio>();

            entregarPedidos += GuardarPedidoEnBD;
            entregarPedidos += EnviarTicketAImprimir;

        }


        public static void AgregarProductoACarrito(Producto producto)
        {
            carritoProductos.Add(producto);
        }

        public static void QuitarProductoACarrito(Producto producto)
        {
            carritoProductos.Remove(producto);
        }

        public static void ConfirmarPedido(Pedido nuevoPedido, Envio nuevoEnvio)
        {
            
            List<Producto> productosConfirmados = new List<Producto>();
            foreach (Producto item in nuevoPedido.DetallePedido)
            {
                productosConfirmados.Add(new Producto(item.IdProducto,item.IdCategoria,item.NombreProducto));
            }
            enviosCompletados.Add(nuevoEnvio);
            nuevoPedido.DetallePedido = productosConfirmados;
            pedidosEnPreparacion.Enqueue(nuevoPedido);
        }

        /// <summary>
        /// Metodo asociado a los hilos para pasar los pedidos de "En preparacion" a "por entregar"
        /// </summary>
        public static void ProcesarPedido()
        {
            Thread.Sleep(10000);
            if (Pizzeria.PedidosEnPreparacion.Count >0)
            {     
                   Pedido pedidoCompletado = pedidosEnPreparacion.Dequeue();
                    pedidosCompletados.Add(pedidoCompletado);
                    entregarPedidos.Invoke();
            }
                
            
        }

        /// <summary>
        /// Metodo que guarda los pedidos en BD, llamando a la clase asociada
        /// </summary>
        public static void GuardarPedidoEnBD()
        {
            foreach (Pedido item in pedidosCompletados)
            {
                BaseDeDatos.GuardarPedido(item);
            }
        }

        /// <summary>
        /// Metodo que imprime los tickets asociados al pedido
        /// </summary>
        public static void EnviarTicketAImprimir()
        {

            foreach (Pedido item in pedidosCompletados)
            {
                ((IArchivos<Pedido>)item).GenerarTicket(item);
                foreach (Envio envio in enviosCompletados)
                {
                    if (envio.NroEnvio == item.NroPedido)
                    {
                        ((IArchivos<Envio>)envio).GenerarTicket(envio);
                    }
                }
            }
            
        }

    }
}
