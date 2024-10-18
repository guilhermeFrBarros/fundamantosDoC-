
namespace ArraysEstudo.ClassEstudos
{
    public class IntroArrays
    {
        public void ArraysMetodo()
        {
            Console.Clear();
            int[] meuArr = new int[6];
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 0;

            Console.WriteLine(meuArray[0]);

            var arrayStruts = new Teste[1];
            arrayStruts[0] = new Teste();

        }
        struct Teste
        {

        }
    }
}