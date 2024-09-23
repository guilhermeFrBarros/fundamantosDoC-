
namespace StringsResto.fundamentos
{
    public class Indices
    {
        internal static void IndiceMet()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("um"));
            Console.WriteLine(texto.LastIndexOf("s"));
            Console.WriteLine(texto.LastIndexOf("te"));
        }
    }
}