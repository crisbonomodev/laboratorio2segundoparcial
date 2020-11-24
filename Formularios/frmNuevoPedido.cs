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

namespace Formularios
{
    public partial class frmNuevoPedido : Form
    {
        List<Producto> categoriaProductos;
        List<Producto> productos;
        List<Producto> listaFiltrarProductos;

        int idProducto = 0;
        public frmNuevoPedido()
        {
            InitializeComponent();
        }
        private void frmNuevoPedido_Load(object sender, EventArgs e)
        {
            productos = new List<Producto>();
            categoriaProductos = new List<Producto>();
            CargarProductos();
            dgvCategoriaProducto.DataSource = categoriaProductos;
            dgvCategoriaProducto.Columns.Remove("Precio");
            listaFiltrarProductos = new List<Producto>();
            cmbEnvio.Items.Add(Envio.ETipoDeEnvio.RetiraEnLocal);
            cmbEnvio.Items.Add(Envio.ETipoDeEnvio.ADomicilio);
            txtDireccion.Enabled = false;
        }
        private void CargarProductos()
        {
            productos = BaseDeDatos.ConsultarProductos();
            categoriaProductos = BaseDeDatos.ConsultarCategorias();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCliente.Text == "")
                {
                    throw new RequiredValueEmptyException("El nombre del cliente debe ser completado");
                }
                if (cmbEnvio.SelectedItem is null)
                {
                    throw new RequiredValueEmptyException("tipo de envio debe ser completado");
                }
                Pedido pedidoAPreparar = new Pedido(txtNombreCliente.Text, Pizzeria.CarritoProductos, 200);
                Envio envioAsociado = new Envio();
                envioAsociado.NroEnvio = pedidoAPreparar.NroPedido;
                switch (cmbEnvio.SelectedIndex)
                {
                    case (int)Envio.ETipoDeEnvio.RetiraEnLocal:
                        envioAsociado.Costo = 0;
                        envioAsociado.TipoDeEnvio = Envio.ETipoDeEnvio.RetiraEnLocal;
                        break;
                    case (int)Envio.ETipoDeEnvio.ADomicilio:
                        envioAsociado.Costo = 100;
                        if (txtDireccion.Text == "")
                        {
                            throw new RequiredValueEmptyException("La direccion de envio debe ser completada");
                        }
                        envioAsociado.Direccion = txtDireccion.Text;
                        envioAsociado.TipoDeEnvio = Envio.ETipoDeEnvio.ADomicilio;
                        break;
                }

                Pizzeria.ConfirmarPedido(pedidoAPreparar, envioAsociado);
                Pizzeria.CarritoProductos.Clear();
                this.Close();
            }
            catch (RequiredValueEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

            }

        }

        private void dgvCategoriaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int idCategoria = (int)dgvCategoriaProducto.SelectedRows[0].Cells[0].Value;

                listaFiltrarProductos.Clear();

                foreach (Producto item in productos)
                {
                    if (item.IdCategoria == idCategoria)
                    {
                        listaFiltrarProductos.Add(item);
                    }
                }
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaFiltrarProductos;
                dgvProductos.Columns.RemoveAt(0);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos que el producto este seleccionado
                if (idProducto != 0)
                {
                    
                    foreach (Producto item in listaFiltrarProductos)
                        {
                        if (idProducto == item.IdProducto)
                        {

                            Pizzeria.AgregarProductoACarrito(item);
                               
                        }
                        }
                    dgvCarrito.DataSource = null;
                    dgvCarrito.DataSource = Pizzeria.CarritoProductos;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = (int)dgvProductos.SelectedRows[0].Cells[2].Value;
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarrito.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione el producto a quitar");
                }
                else
                {
                    int idProductoARemover = (int)dgvCarrito.SelectedRows[0].Cells[2].Value;
                    foreach (Producto item in listaFiltrarProductos)
                    {
                        if (idProductoARemover == item.IdProducto)
                        {

                            Pizzeria.QuitarProductoACarrito(item);
                        }
                    }
                    dgvCarrito.DataSource = null;
                    dgvCarrito.DataSource = Pizzeria.CarritoProductos;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEnvio.SelectedIndex)
            {
                case (int)Envio.ETipoDeEnvio.RetiraEnLocal:
                    txtDireccion.Enabled = false;
                    break;
                case (int)Envio.ETipoDeEnvio.ADomicilio:
                    txtDireccion.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
