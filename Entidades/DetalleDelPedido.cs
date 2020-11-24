using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleDelPedido<T>
    {

        private List<List<T>> listaDePedidos;
        private int idPedido;
        private int tiempoPreparacion;
        private string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public int TiempoPreparacion
        {
            get { return tiempoPreparacion; }
            set { tiempoPreparacion = value; }
        }

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public List<List<T>> ListaDePedidos
        {
            get { return listaDePedidos; }
            set { listaDePedidos = value; }
        }

        public DetalleDelPedido()
        {
            if (listaDePedidos.Count == 0)
            {
                idPedido = 1;
            }
            else
            {
                idPedido = listaDePedidos.Count + 1;
            }
        }

        public DetalleDelPedido(string nombreCliente,int tiempoPreparacion, List<Pedido> detallePedido)
        {
            this.nombreCliente = nombreCliente;
            this.tiempoPreparacion = tiempoPreparacion;
        }
        
    }
}
