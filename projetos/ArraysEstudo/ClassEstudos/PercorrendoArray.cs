namespace ArraysEstudo.ClassEstudos
{
    public class PercorrendoArray
    {
        public void PercorrendoArrayMetodo()
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            Console.WriteLine(meuArray.Length);

            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            // Serve para clonar o array, pois é uma referenceType
            var meuArrayCopia = (int[])meuArray.Clone();
            meuArrayCopia[1] = 8;

            // Imprime os elementos do array original
            Console.WriteLine("Array original: " + string.Join(", ", meuArray));

            // Imprime os elementos do array copiado
            Console.WriteLine("Array copiado: " + string.Join(", ", meuArrayCopia));
        }
    }
}
