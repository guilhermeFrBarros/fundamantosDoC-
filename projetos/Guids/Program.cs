namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guids =>");
            Console.WriteLine("é usado muito para cria indentificador unicos");


            var id = Guid.NewGuid();
            Console.WriteLine(id.GetType());

            var id2 = id.ToString();
            Console.WriteLine("\n" + id2.GetType());
            Console.WriteLine(id2.Substring(0, 8));


        }
    }
}