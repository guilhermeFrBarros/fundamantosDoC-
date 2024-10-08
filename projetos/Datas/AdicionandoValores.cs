using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class AdicionandoValores
    {
        public void AdicionandoValoresMe()
        {
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(-12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddHours(8));
        }
    }
}