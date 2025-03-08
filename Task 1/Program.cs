using System;

namespace Task_1
{
    internal class Program
    {
        static void PrintMessage1()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Таймер 1 ");
        }

        static void PrintMessage2()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Таймер 2 ");
        }

        static void Main()
        {
      
            Timer timer1 = new Timer(PrintMessage1, 2);
            Timer timer2 = new Timer(PrintMessage2, 3);

            timer1.StartAsync(2); 
            timer2.StartAsync(3); 

            Console.WriteLine("Таймери запущені у фонових потоках");
            Console.ReadLine(); 
        }

    }
}
