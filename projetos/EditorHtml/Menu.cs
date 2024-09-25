using System;

namespace EditorHtml
{
    public class Menu
    {
        public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public void DrawScreen(int tamanhoLinha = 30, int tamanhoColuna = 10)
        {
            ConstruirLinha(tamanhoLinha);
            ConstruirColunas(tamanhoColuna, tamanhoLinha);
            ConstruirLinha(tamanhoLinha);
        }

        public void WriteOptions()
        {
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione a Opção abaixo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

        private void ConstruirColunas(int tamanhoColuna, int tamanhoLinha)
        {
            for (int lines = 0; lines <= tamanhoColuna; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= tamanhoLinha; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        private void ConstruirLinha(int tamanhoLinha)
        {
            Console.Write("+");
            for (int i = 0; i <= tamanhoLinha; i++) Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}