using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos
{
    public class StartWithEndsWith
    {
        internal static void StartWithEndsWithExec()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("E"));// True
            Console.WriteLine(texto.StartsWith("Este"));// True
            Console.WriteLine(texto.StartsWith("este"));// False
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));// True
            Console.WriteLine(texto.StartsWith("texto"));// False

            Console.WriteLine(texto.EndsWith("teste"));// True
            Console.WriteLine(texto.EndsWith("Teste"));// False
            Console.WriteLine(texto.EndsWith("xpox"));// False
        }
    }
}