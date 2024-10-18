using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Moedas.classes
{
    public class TiposParaMoedas
    {
        public void TiposParaMoedasM()
        {
            Console.Clear();
            var valor1 = 10.25;
            // Na maioria dos casos usar o tipo decimal
            decimal valor2 = 10.25m;
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        }

        public void FormatandoMoedas()
        {
            Console.Clear();

            decimal valor = 1234.5678m;
            int inteiro = 255;
            // Formata o valor como moeda
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // R$ 1.234,57

            // Formata o valor como percentual
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); // 123.456,78 %

            // Formata o valor como número com separadores de milhar e duas casas decimais
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); // 1.234,57

            // Formata o valor em notação científica (exponencial)
            Console.WriteLine(valor.ToString("E", CultureInfo.CreateSpecificCulture("pt-BR"))); // 1,234568E+003

            // Formata o valor como um número fixo de casas decimais
            Console.WriteLine(valor.ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR"))); // 1234,57

            // Formato geral, que usa o formato mais compacto entre o formato fixo e o formato científico
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // 1234,5678

            // Formata o número como um inteiro decimal (usado principalmente para inteiros)
            Console.WriteLine(inteiro.ToString("D", CultureInfo
            .CreateSpecificCulture("pt-BR"))); // 255

            // Formata o número como um valor hexadecimal
            Console.WriteLine(inteiro.ToString("X", CultureInfo
                                .CreateSpecificCulture("pt-BR"))); // FF
        }

        public void TestDoMath()
        {
            Console.Clear();
            decimal valor = 10536.25m;


            // Arredonda o valor para o inteiro mais próximo
            Console.WriteLine(Math.Round(valor)); // 10536

            // Arredonda o valor para o menor inteiro mais próximo
            Console.WriteLine(Math.Floor(valor)); // 10536

            // Arredonda o valor para o maior inteiro mais próximo
            Console.WriteLine(Math.Ceiling(valor)); // 10537
        }
    }
}