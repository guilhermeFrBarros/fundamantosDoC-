namespace StringsResto.fundamentos
{
    public class MetodosAdd
    {
        internal static void MetodosAddM()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());// este texto é um teste
            Console.WriteLine(texto.ToUpper());// ESTE TEXTO É UM TESTE
            Console.WriteLine(texto.Insert(5, "AQUI "));// Este AQUI texto é um teste
            Console.WriteLine(texto.Remove(5, 5));// Este  é um teste
            Console.WriteLine(texto.Length); // 21
        }

    }
}