namespace Datas
{
    public class ComparnadoDatas
    {
        public void ComparnadoDatasM()
        {
            var date = DateTime.Now;

            Console.WriteLine("date ==  DateTime.Now => " + date + " " + (date == DateTime.Now));
            Console.WriteLine("date.Date ==  DateTime.Now.Date => " + date.Date + " " + (date.Date == DateTime.Now.Date));
        }
    }
}