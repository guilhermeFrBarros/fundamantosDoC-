

using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {

        public void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO View");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("----------x");
            Console.ReadKey();
            Menu menu = new Menu();
            menu.Show();

        }

        public void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(
                         words[i].Substring(
                            words[i].IndexOf('>') + 1,
                           (
                                (words[i].LastIndexOf('<') - 1)
                                - words[i].IndexOf('>')
                            )
                         )
                    );
                    Console.Write(' ');
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

            // Console.WriteLine(strong);
        }
    }
}