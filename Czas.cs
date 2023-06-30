using System;

namespace Zadanie
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(FormatujCzas(852));
        }

        public static string FormatujCzas(int sekundy)
        {
            TimeSpan czas = TimeSpan.FromSeconds(sekundy);

            return czas.ToString(@"hh\:mm\:ss");
        }
    }
}
