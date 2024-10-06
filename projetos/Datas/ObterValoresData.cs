
namespace Datas
{
    public class ObterValoresData
    {
        public void ValoresData()
        {
            Console.Clear();
            Console.WriteLine("Obetendo os valores da data");
            var data = new DateTime(2024, 10, 04, 18, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);

        }
    }
}