using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Extension de DateTime que devuelve el tiempo transcurrido entre dos fechas
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static TimeSpan TimeElapsed(this DateTime date)
        {
            return DateTime.Now - date;
        }
    }
}
