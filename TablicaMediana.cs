using System;
using System.Linq;

namespace Zadanie1
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[100];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }

            Console.WriteLine("Mediana wynosi to: " + CalculateMedian(array));
        }

        static double CalculateMedian(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);
            Array.Sort(sortedArray);

            int size = sortedArray.Length;
            int mid = size / 2;

            if (size % 2 != 0)
            {
                return sortedArray[mid];
            }
            else
            {
                return (sortedArray[mid - 1] + sortedArray[mid]) / 2.0;
            }
        }
    }
}
