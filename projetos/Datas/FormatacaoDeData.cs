using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class FormatacaoDeData
    {
        public void FormatacaoDeDataMe()
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);
            var formatada2 = $"{data:dd/MM/yyyy hh:mm:ss fff}";
            Console.WriteLine(formatada2);

        }

    }
}