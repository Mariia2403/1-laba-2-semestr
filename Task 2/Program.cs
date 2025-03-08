using System;
using System.Linq;

namespace Task_2
{
    delegate bool FilterDelegate(int number, int k);
    internal class Program
    {
        static bool IsDivisible(int number, int k)
        {
            return number % k == 0;
        }

        static int[] FilterWithLinq(int[] numbers, int k, FilterDelegate filter)
        {

            return numbers.Where(n => filter(n, k)).ToArray();
        }

        static int[] FilterManual(int[] numbers, int k, FilterDelegate filter)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (filter(numbers[i], k)) count++;
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (filter(numbers[i], k))
                {
                    result[index] = numbers[i];
                    index++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter array:");

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter number k:");
            int k = int.Parse(Console.ReadLine());

            FilterDelegate filter = IsDivisible;

            int[] result1 = FilterWithLinq(numbers, k, filter);
            int[] result2 = FilterManual(numbers, k, filter);

            Console.WriteLine("Result via LINQ:"+ string.Join(",",result1));
            Console.WriteLine("Result without LINQ:" + string.Join(",", result2));

            Console.ReadLine();

        }
    }
}
