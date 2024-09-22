namespace InterpolacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            var texto = "O preço do Produto é ";
            // Sempre que vc concateno com uma String o outro tipo vira uma String
            Console.WriteLine(texto + price);

            // Intepola atraves das {}, quando enxerga dentro da string as {0} e sobstitui pelo que vem a após a vigula conforme a posição dentro das {0}
            var texto2 = string.Format("o preço do produto é {0} apenas na promoção, => {1}", price, "test");
            Console.WriteLine("\n" + texto2);

            var texto3 = $"\nO preço do produto é {price} apenas na promo";
            string texto4 = $@"O @ serve para vc poder escrever em varias 
            linhas como nesse
            exemplo";
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
        }
    }
}

