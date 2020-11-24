using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.IO;

namespace Formularios
{
    
    public partial class frmPrincipal : Form
    {

        public delegate void ActualizarInformacion();
        public event ActualizarInformacion actualizacion;

        List<Thread> listaThreads = new List<Thread>();
        Thread hiloPrincipal;
        Thread hiloActualizar;
        public frmPrincipal()
        {
            hiloPrincipal = new Thread(this.Comenzar);
            hiloActualizar = new Thread(this.ActualizarDatagrids);
            InitializeComponent();

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(Archivos.Ruta))
            {
               Pizzeria.PedidosEnPreparacion = Archivos.LeerDeArchivo();

                foreach (Pedido item in Pizzeria.PedidosEnPreparacion)
                {
                    AgregarNuevoThread();
                }
            }

            if (!hiloPrincipal.IsAlive)
            {
                listaThreads.Add(hiloPrincipal);
                hiloPrincipal.Start();
                listaThreads.Add(hiloActualizar);
                hiloActualizar.Start();
            }

            actualizacion += ActualizarFechaYHora;
            actualizacion += ActualizarTiempoDePreparacion;
            actualizacion += ActualizarDatagrids;
        }

        public void Comenzar()
        {

            do
            {
                ActualizarDatagrids();

            } while (true);
        }

        /// <summary>
        /// Metodo que chequea si el listView necesita actualizacion por parte del hilo, y en ese caso lanza el metodo asociado
        /// </summary>
        private void ActualizarDatagrids()
        {
            if (this.lstEnPreparacion.InvokeRequired)
            {
                this.lstEnPreparacion.BeginInvoke((MethodInvoker)delegate ()
                {
                    ActualizarPedidos();
                });
            }
            Thread.Sleep(1000);
        }
        /// <summary>
        /// Metodo de actualizacion que verifica si hay nuevos pedidos y actualiza los grids.
        /// </summary>
        private void ActualizarPedidos()
        {
            int cantidadPedidosCompletados = 0; 
            try
            {
                lstEnPreparacion.Items.Clear();
                if (Pizzeria.PedidosEnPreparacion.Count > 0)
                {           
                    foreach (Pedido pedido in Pizzeria.PedidosEnPreparacion.ToArray())
                    {
                        ListViewItem item = new ListViewItem(pedido.NroPedido.ToString());
                        item.SubItems.Add(pedido.NombreCliente);
                        item.SubItems.Add(pedido.FechaYHora.ToString());
                        item.SubItems.Add(pedido.TotalPedido.ToString("#.##"));
                        item.SubItems.Add(pedido.TiempoPreparacion.ToString());
                        lstEnPreparacion.Items.Add(item);
                    }
                }

                if (cantidadPedidosCompletados != Pizzeria.PedidosCompletados.Count)
                { 
                    dgvCompletados.DataSource = null;
                    dgvCompletados.DataSource = Pizzeria.PedidosCompletados;
                    cantidadPedidosCompletados = Pizzeria.PedidosCompletados.Count;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Metodo de actualizacion de fecha y hora mostrada en el form
        /// </summary>
        private void ActualizarFechaYHora()
        {
            lblFechaYHora.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Metodo que actualiza el tiempo de preparacion en base al metodo de extension TimeElapsed
        /// </summary>
        private void ActualizarTiempoDePreparacion()
        {
            foreach (Pedido pedidoEnPreparacion in Pizzeria.PedidosEnPreparacion)
            {
                pedidoEnPreparacion.TiempoPreparacion = pedidoEnPreparacion.FechaYHora.TimeElapsed();
            }
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            
            frmNuevoPedido frmNuevoPedido = new frmNuevoPedido();
            frmNuevoPedido.ShowDialog();
            AgregarNuevoThread();


        }

        /// <summary>
        /// Metodo que agrega un thread nuevo para entrega de pedidos
        /// </summary>
        public void AgregarNuevoThread()
        {
            Thread miNuevoThread = new Thread(Pizzeria.ProcesarPedido);
            listaThreads.Add(miNuevoThread);
            miNuevoThread.Start();
        }

        /// <summary>
        /// Timer que lanza los metodos de actualizacion requeridos para la informacion visualizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerActualizarPedidos_Tick(object sender, EventArgs e)
        {
            actualizacion.Invoke();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread hilo in listaThreads)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
            if (Pizzeria.PedidosEnPreparacion.Count > 0)
            { 
            Archivos.EscribirAArchivo(Pizzeria.PedidosEnPreparacion);
            }
        }
    }
}
