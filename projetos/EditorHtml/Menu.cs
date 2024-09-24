using System;

namespace EditorHtml
{
    public class Menu()
    {
        public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
        }

        public void DrawScreen(int tamanhoColunas = 30, int tamanholinha = 10)
        {
            ConstruirLinha(tamanhoColunas);
            ConstruirColuna(tamanholinha);

            ConstruirLinha(tamanhoColunas);
        }

        private void ConstruirColuna(int tamanholinha)
        {
            for (int lines = 0; lines <= tamanholinha; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        private void ConstruirLinha(int tamanhoColunas)
        {
            Console.Write("+");
            for (int i = 0; i <= tamanhoColunas; i++) Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}