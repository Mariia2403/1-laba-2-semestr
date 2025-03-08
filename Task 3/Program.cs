using System;

namespace Task_3
{
    internal class Program
    {
        public delegate double SeriesTerm(int i);

       
        public static double CalculateSeriesSum(SeriesTerm term, double precision)
        {
            double sum = 0.0;
            int i = 1; 
            double currentTerm;

            do
            {
                currentTerm = term(i);
                sum += currentTerm;
                i++;
            } while (Math.Abs(currentTerm) > precision); 

            return sum;
        }

        
        static void Main(string[] args)
        {

            double precision = 1e-6;

            SeriesTerm series1 = delegate (int i)
            {

                double denominator = 1;
                for (int j = 1; j < i; j++)
                {
                    denominator *= 2; 
                }
                return 1.0 / denominator;
            };

            
            Console.WriteLine("Сума ряду 1: " + CalculateSeriesSum(series1, precision));

            SeriesTerm series2 = delegate (int i)
            {
                double fact = 1;
                for (int j = 2; j <= i; j++)
                {
                    fact *= j;
                }
                return 1.0 / fact;
            };

            Console.WriteLine("Сума ряду 2: " + CalculateSeriesSum(series2, precision));

            SeriesTerm series3 = delegate (int i)
            {
                double denominator = 1;
                for (int j = 1; j < i; j++)
                {
                    denominator *= 2; 
                }
                return (i % 2 == 0 ? -1 : 1) * (1.0 / denominator);

            };

            Console.WriteLine("Сума ряду 3: " + CalculateSeriesSum(series3, precision));

            Console.ReadLine();
        }
    }
}
