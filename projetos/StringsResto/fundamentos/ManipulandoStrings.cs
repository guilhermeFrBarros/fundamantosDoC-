using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringsResto.fundamentos
{
    public class ManipulandoStrings
    {
        internal static void ManipulandoStringsMet()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("e", "X"));

            var divisao = texto.Split(' ');
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);
            resultado = texto.Substring(5, texto.IndexOf("o") - 5 + 1);
            Console.WriteLine(resultado);
            // limpa os espaços em branco no final e no começo
            Console.WriteLine(texto.Trim());
        }
    }
}