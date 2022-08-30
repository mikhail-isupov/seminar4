// Вычисляем сумму цифр в числе
using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = SumOfDigits(number);

            Console.WriteLine($"Сумма цифр в числе {number} составляет {sumOfDigits}");
        }

        static int SumOfDigits(int number)
        {
            int slicedNumber = number;
            int lastDigit = 0;
            int sumOfDigits = 0;

            while (slicedNumber != 0)
            {
                lastDigit = slicedNumber % 10;
                sumOfDigits += lastDigit;
                slicedNumber /= 10;
            }

            return sumOfDigits;
        }
    
    }
}

