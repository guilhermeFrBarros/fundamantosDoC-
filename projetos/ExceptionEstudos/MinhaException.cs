using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionEstudos
{
    public class MinhaException : Exception
    {
        public DateTime QuandoAconteceu { get; set; }

        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
    }
}