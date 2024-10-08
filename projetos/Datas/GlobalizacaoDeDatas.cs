using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class GlobalizacaoDeDatas
    {
        public void GlobalizacaoDeDatasM()
        {
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var culturaDaMaquina = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", culturaDaMaquina));
        }
    }
}