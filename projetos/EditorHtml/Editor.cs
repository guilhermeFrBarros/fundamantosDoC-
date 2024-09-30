
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine); // Environment.NewLine em C# é usada para inserir quebras de linha  de forma que ele seja compatível com o sistema operacional onde o código está sendo executado. = ao  \n no inux
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("Deseja  salvar o arquivo?");
            Viewer viewer = new Viewer();
            viewer.Show(file.ToString());
        }
    }
}