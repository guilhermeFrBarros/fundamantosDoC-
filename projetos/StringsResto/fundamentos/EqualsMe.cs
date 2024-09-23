
namespace StringsResto.fundamentos
{
    public class EqualsMe
    {
        internal void EqualsMetodo()
        {
            var texto = "Este texto é um teste";
            int test = 33;

            Console.WriteLine(test.Equals(33));

            Console.WriteLine(texto.Equals("Este texto é um teste")); // True
            Console.WriteLine(texto.Equals("este texto é um teste"));// False
            Console.WriteLine(texto.Equals("este texto é um teste",
             StringComparison.OrdinalIgnoreCase)); // True

        }
    }
}