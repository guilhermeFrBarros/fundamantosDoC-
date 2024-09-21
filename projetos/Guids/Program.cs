namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guids =>");
            Console.WriteLine("é usado muito para cria indentificador unicos");

            var id = Guid.NewGuid();
            Console.WriteLine("\n" + id);
        }
    }
}