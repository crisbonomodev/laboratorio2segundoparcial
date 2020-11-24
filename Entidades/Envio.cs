using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Envio : IArchivos<Envio>
    {
        public enum ETipoDeEnvio
        {
        RetiraEnLocal,
        ADomicilio
        }
        #region Atributos y Propiedades

        private int nroEnvio;
        private ETipoDeEnvio tipoDeEnvio;
        private string direccion;
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public ETipoDeEnvio TipoDeEnvio
        {
            get { return tipoDeEnvio; }
            set { tipoDeEnvio = value; }
        }

        public int NroEnvio
        {
            get { return nroEnvio; }
            set { nroEnvio = value; }
        }
        #endregion

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Envio()
        {

        }

        void IArchivos<Envio>.GenerarTicket(Envio miEnvio)
        {
            DateTime fechaHora = new DateTime();
            fechaHora = DateTime.Now;
            StreamWriter sw = File.CreateText($"Envio Nro{miEnvio.NroEnvio}.txt");
            sw.WriteLine($"Pizzeria - Recibo X - Envio Nro{miEnvio.NroEnvio} ");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"{fechaHora}");
            sw.WriteLine("---------------------------");
            switch (miEnvio.TipoDeEnvio)
            {
                case ETipoDeEnvio.RetiraEnLocal:
                    sw.WriteLine("Tipo de Envío: Retira en Local");
                    break;
                case ETipoDeEnvio.ADomicilio:
                    sw.WriteLine("Tipo de Envío: A Domicilio");
                    sw.WriteLine($"Direccion: {miEnvio.Direccion}");
                    break;
                default:
                    break;
            }
            sw.WriteLine("---------------------------");
            sw.WriteLine("---------------------------");
            sw.Close();

        }
    }
}
