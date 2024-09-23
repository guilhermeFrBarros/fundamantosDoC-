using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsResto.fundamentos
{
    public class StringBuilderClas
    {
        internal static void StringBuilderMet()
        {
            var texto = new StringBuilder("Este texto é um teste");
            texto.Append(" - inseração de string 1 ");
            texto.Append(" - inseração de string 2 ");

            Console.WriteLine(texto);

        }
    }
}