using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
namespace Entidades
{
    public static class Archivos
    {
        #region Atributos y Propiedades

        static string ruta = AppDomain.CurrentDomain.BaseDirectory + "pedidosEnPreparacion.xml";

        public static string Ruta
        {
            get
            {
                return ruta;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo para serializar en XML los pedidos en preparacion
        /// </summary>
        /// <param name="pedidosAGuardar"></param>
        public static void EscribirAArchivo(Queue<Pedido> pedidosAGuardar)
        {
            using (XmlTextWriter auxWriter = new XmlTextWriter(ruta,Encoding.UTF8)) 
            {
                XmlSerializer auxSerializer = new XmlSerializer(typeof(Pedido));

                foreach (Pedido item in pedidosAGuardar)
                {
                    auxSerializer.Serialize(auxWriter, item);
                }  
            }
        }

        /// <summary>
        /// Metodo para deserializar desde XML los pedidos en preparacion guardados
        /// </summary>
        /// <returns></returns>
        public static Queue<Pedido> LeerDeArchivo()
        {
            Queue<Pedido> miQueueARestaurar = new Queue<Pedido>();
            if (File.Exists(ruta))
            { 
            using (XmlTextReader auxReader = new XmlTextReader(ruta))
            {
                XmlSerializer auxSerializer = new XmlSerializer(typeof(Pedido));

                    Pedido pedidoARestaurar = new Pedido();
                    pedidoARestaurar =(Pedido) auxSerializer.Deserialize(auxReader);
                    miQueueARestaurar.Enqueue(pedidoARestaurar);
            }
            
            }
            File.Delete(Ruta);
            return miQueueARestaurar;
        }

        #endregion
    }
}
