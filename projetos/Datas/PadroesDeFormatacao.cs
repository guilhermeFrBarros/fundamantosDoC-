using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class PadroesDeFormatacao
    {
        public void PadroesDeFormatacaoM()
        {
            Console.Clear();
            var data1 = DateTime.Now;
            //o t serve para mostrar a menor data possivel 
            var formatada = String.Format("{0:t}", data1);
            Console.WriteLine(formatada);

            var formatadaT = String.Format("{0:T}", data1);
            Console.WriteLine(formatadaT);

            var formatadaD = String.Format("{0:D}", data1);
            Console.WriteLine(formatadaD);

            var formatadaf = String.Format("{0:f}", data1);
            Console.WriteLine(formatadaf);

            var formatadag = String.Format("{0:g}", data1);
            Console.WriteLine(formatadag);

            var formataday = String.Format("{0:y}", data1);
            Console.WriteLine(formataday);

            var formatadaR = String.Format("{0:R}", data1);
            Console.WriteLine(formatadaR);

            var formatadar = String.Format("{0:r}", data1);
            Console.WriteLine(formatadar);

            var formatadas = String.Format("{0:s}", data1);
            Console.WriteLine(formatadas);

            var formatadau = String.Format("{0:u}", data1);
            Console.WriteLine(formatadau);

        }
    }
}