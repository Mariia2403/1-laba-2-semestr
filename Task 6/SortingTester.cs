using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_6_test2_
{
    internal class SortingTester
    {
        public delegate void SortDelegate(int[] array);
       // public readonly SortDelegate[] sortingMethods = { }
        private readonly string[] fileNames = { "random.txt", "partially_sorted.txt", "reverse_sorted.txt" };
        private readonly string directoryPath = @"D:\Visual Studio (2)\2 курс\2 семестр\ооп лаби\1 Lab\Task 6\bin\Debug";
        public List<string> outputResult;
       /* long referenceTime;
        long studentTime;
        bool isComparable;*/
        public bool RunTests(SortDelegate etalonSort , SortDelegate studentSort)
        {
            //bool correctDate = false;
            outputResult = new List<string>();
            bool selectionCorrect = false;
            foreach (var file in fileNames)
            {
                string fullPath = Path.Combine(directoryPath, file);//повний шлях до файлу
                int[] array = ReadFile(fullPath);

                if (array.Length == 0)
                {
                    outputResult.Add($"Файл {file} не знайдено");
                    continue;
                }

                outputResult.Add($"Масив з файлу {file}: {string.Join(", ", array)} ");


                long referenceTime = MeasureSortingTime(etalonSort, array, 0).time;

                var (studentTime, isComparable) = MeasureSortingTime(studentSort, array, referenceTime);

                selectionCorrect = CompareSortings(etalonSort, studentSort, array);
              
                outputResult.Add($"Еталонне сортування: {referenceTime} мс");
                outputResult.Add($"Студентське сортування: {studentTime} мс → {(isComparable ? "Співмірне" : "НЕ співмірне")}");
                outputResult.Add($"Правильність сортування: {(selectionCorrect ? "Вірно" : "Помилка")}");
               

                if (!selectionCorrect)
                { 
                 return false;
                }
            }
            return selectionCorrect;
        }
        public int[] ReadFile(string fileName)
        {
            /*string directoryPath = @"D:\Visual Studio (2)\2 курс\2 семестр\ооп лаби\1 Lab\Task 6\bin\Debug";
            string fullPath = Path.Combine(directoryPath, fileName); // Формуємо правильний шлях
*/
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"Помилка: Файл {fileName} не знайдено!");
                return new int[0];
            }
            string[] lines = File.ReadAllLines(fileName);

            return Array.ConvertAll(lines, int.Parse);//конвертуємо наш масив що ми отримали з файлу
        }
        public static bool CompareSortings(SortDelegate etalonSort, SortDelegate studentSort, int[] array)
        {
            int[] etalonArray = (int[])array.Clone();
            int[] studentArray = (int[])array.Clone();

            etalonSort(etalonArray);
            studentSort(studentArray);

            return etalonArray.SequenceEqual(studentArray);
        }
        public static (long time, bool isComparable) MeasureSortingTime(SortDelegate sortingMethod, int[] array, long referenceTime)
        {
            int[] tempArray = (int[])array.Clone();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            sortingMethod(tempArray);

            stopwatch.Stop();
            long measuredTime = stopwatch.ElapsedTicks;

            // Обчислюємо межі для перевірки співмірності
            long lowerBound = Math.Max(0, referenceTime / 5 - 200);
            long upperBound = 5 * referenceTime + 200;

            // Перевіряємо, чи потрапляє `measuredTime` у цей діапазон
            bool isComparable = measuredTime >= lowerBound && measuredTime <= upperBound;

            return (measuredTime, isComparable);
        }
    }
}
