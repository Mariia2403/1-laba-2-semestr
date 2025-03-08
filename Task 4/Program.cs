using System;

namespace Task_4
{
    delegate double Func(double number);
    internal class Program
    {
        static double FindSquareRoot(double num) => Math.Sqrt(num);
        static double FindCube(double num) => Math.Pow(num, 3);
        static double AddValue(double num) => num + 3.5;

        static void Main(string[] args)
        {
            Func[] funcs = new Func[]
           {
                FindSquareRoot, 
                FindCube,      
                AddValue       
           };

            Console.WriteLine("Enter the operation number (0 - square root, 1 - cube, 2 - add 3.5) and a number:");

            while (true)
            {
                    string input = Console.ReadLine();
                try
                {
                    string[] parts = input.Split(' ');

                    if (parts.Length != 2)
                        throw new Exception("Invalid input!");

                    int firstValue = int.Parse(parts[0]);
                    double secondValue = double.Parse(parts[1]);

                    if (firstValue < 0 || firstValue >= funcs.Length)
                        throw new Exception("Invald operation number!");

                    Console.WriteLine("Result: " + funcs[firstValue](secondValue));

                    Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error! {ex.Message}");
                    Console.WriteLine("Exiting program...");
                    break; 
                }
            }


        }
    }
}
