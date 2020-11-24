using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitariosBD
    {
        [TestMethod]
        public void ConsultarCategoriasEnBD()
        {
            //Arrange
            List<Producto> listaProductos;
            //Act
             listaProductos = new List<Producto>(BaseDeDatos.ConsultarCategorias());
            //Assert
            Assert.IsNotNull(listaProductos);
        }

        [TestMethod]
        public void ConsultarProductosEnBD()
        {
            //Arrange
            List<Producto> listaProductos;
            //Act
            listaProductos = new List<Producto>(BaseDeDatos.ConsultarProductos());
            //Assert
            Assert.IsNotNull(listaProductos);
        }

        //
        [TestMethod]
        public void ObtenerUltimoPedidoConfirmado()
        {
            //Arrange
            int numeroPedido;
            //Act
            numeroPedido = BaseDeDatos.ObtenerUltimoPedidoConfirmado();
            //Assert
            Assert.IsNotNull(numeroPedido);
        }

       
    }
}
