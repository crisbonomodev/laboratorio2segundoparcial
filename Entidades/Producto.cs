using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        #region atributos
        private int idProducto;
        private int idCategoria;
        string nombreProducto;
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        #endregion

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }


        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public int IdProducto

        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public Producto()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <param name="nombreProducto"></param>
        public Producto(int idCategoria, string nombreProducto)
        {
            this.nombreProducto = nombreProducto;
            this.idCategoria = idCategoria;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="idCategoria"></param>
        /// <param name="nombreProducto"></param>
        public Producto(int idProducto,int idCategoria,string nombreProducto) :this(idCategoria,nombreProducto)
        {
            this.idProducto = idProducto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="idCategoria"></param>
        /// <param name="nombreProducto"></param>
        /// <param name="tamanioProducto"></param>

    }
}
