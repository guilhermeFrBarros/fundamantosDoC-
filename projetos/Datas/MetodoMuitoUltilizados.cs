using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datas
{
    public class MetodoMuitoUltilizados
    {
        public void metodo()
        {
            // Mostra quantos dias tem o mes de determinado ano
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            // Verifica se o dia da semana é final de semana
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            // retorna bool para se estamos em horario de Verão
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}