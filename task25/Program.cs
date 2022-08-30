// Возводим целое число X в целую степень Y

using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int power = 1; 
            
            while(number != 0)
            {
                Console.WriteLine("Введите целочисленное основание степени X: ");
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите целочисленный показатель степени Y: ");
                power = int.Parse(Console.ReadLine());

                Console.WriteLine($"Результат {number}^{power} = " + Math.Pow(number, power));
            }
                
        }
    }
}
