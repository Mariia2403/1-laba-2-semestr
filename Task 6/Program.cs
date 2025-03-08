using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_test2_
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            SortingTester tester = new SortingTester();
            bool sortSelectionResult =  tester.RunTests(EtalonSorts.SelectionSort, StudentSelectionSort.Sort);
          
            OutputResult("Selection sort",sortSelectionResult, tester.outputResult);
            Console.WriteLine();
            bool sortShakerResult = tester.RunTests(EtalonSorts.ShakerSort, StudentShakerSort.Sort);
            OutputResult("Shaker sort",sortShakerResult,tester.outputResult);

           
            Console.ReadLine();

        }

        public static void OutputResult(string typeSort,bool sortResult,List<string> outputResult)
        {
          //  Console.WriteLine();
            Console.WriteLine(typeSort);
            foreach (string line in outputResult)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(line);
            }
            Console.WriteLine(sortResult ? "Правильно" : "Неправильно");
        }
    }
}
