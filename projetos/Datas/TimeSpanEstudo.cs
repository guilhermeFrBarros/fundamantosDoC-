using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class TimeSpanEstudo
    {
        public void TimeSpanMetodo()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine($"TimeSpan() => {timeSpan}");

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine($"TimeSpan(1) => {timeSpanNanoSegundos}");

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine($"timeSpanHoraMinutoSegundo => {timeSpanHoraMinutoSegundo}");

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine($"timeSpanDiaHoraMinutoSegundo => {timeSpanDiaHoraMinutoSegundo}");

            var timeSpanDiaHoraMinutoSegundoMiliSegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine($"timeSpanDiaHoraMinutoSegundoMiliSegundo => {timeSpanDiaHoraMinutoSegundoMiliSegundo}");

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }
    }
}