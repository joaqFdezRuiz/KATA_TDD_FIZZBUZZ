using System;
using System.Linq;

namespace KataFizzBuzz
{
    public class KataFizzBuzz : IKataFizzBuzz
    {
        public string Game(string values)
        {
            if ((EsDivisible(values, 3) && EsDivisible(values, 5)) ||
                (ContieneNumero(values, '3') && ContieneNumero(values, '5')))

                return "FizzBuzz";

            if (EsDivisible(values, 3) || ContieneNumero(values, '3'))
                return "Fizz";

            if (EsDivisible(values, 5) || ContieneNumero(values, '5'))
                return "Buzz";
            
            return values;
        }

        private static bool ContieneNumero(string values, char numero)
        {
            return values.Select(x => x).Contains(numero);
        }

        private static bool EsDivisible(string values, int divisor)
        {
            return Int32.Parse(values) % divisor == 0;
        }
    }
}
