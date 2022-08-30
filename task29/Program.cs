using System;
// Создаем массив int[] произвольной длины size и заполняем случайными int-ами в интервале [minValue, maxValue]
namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размер массива:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное значение элемента массива:");
            int minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение элемента массива:");
            int maxValue = int.Parse(Console.ReadLine());

            int[] array = ArrayConstructor(size, minValue, maxValue);
            PrintArray(array);
        }

        static int[] ArrayConstructor(int size, int minValue, int maxValue)
        {
            
            int[] array = new int[size]; 
            Random number = new Random();

            for (int i = 0; i < size; i++) array[i] = number.Next(minValue, maxValue + 1);

            Console.WriteLine($"Создан массив размером {size}, заполненный случайными числами в интервале {minValue} - {maxValue}");

            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Выводим содержимое массива:");
            for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");
            Console.WriteLine();
        }


    }
}
