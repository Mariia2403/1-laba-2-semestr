using System;

namespace Task_1
{
    internal class Program
    {

        static void PrintMessage()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Виконується метод");
        }

        static void Main()
        {
            Timer timer = new Timer(PrintMessage, 2);
            timer.StartAsync(5);

            Console.WriteLine("Таймер працює у фоновому режимі!");
            Console.ReadLine(); 
            timer.Stop(); 
            Console.ReadLine();
        }

    }
}
