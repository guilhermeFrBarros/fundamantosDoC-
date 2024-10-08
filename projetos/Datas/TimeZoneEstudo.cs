namespace Datas
{
    public class TimeZoneEstudo
    {
        public void TimeZoneMet()
        {
            var utcDate = DateTime.UtcNow;

            Console.WriteLine($"horario ataul no meu sistema => {DateTime.Now}"); // horario ataul no meu sistema => 10/8/2024 9:23:16 AM

            Console.WriteLine($"horario UTC  => {utcDate}"); // horario UTC  => 10/8/2024 12:23:16 PM

            Console.WriteLine($"horario UTC convertido  => {utcDate.ToLocalTime()}"); // horario UTC convertido  => 10/8/2024 9:23:16 AM

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);// (UTC+12:00) New Zealand Time

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            Console.WriteLine($"Data da Australia {horaAustralia}"); // Data da Australia 10/9/2024 1:29:04 AM

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("");
            }
        }
    }
}