// Возводим вещественное число X в целую степень Y

using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание степени X: ");
            double number = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите целочисленный показатель степени Y: ");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат {number}^{power} = " + intPow(number, power));
            
                
        }

        static double intPow(double number, int power)
        {
            double result = 1;
            int index = Math.Abs(power);

            for (int i = 0; i < index; i++) result *= number;

            return (power < 0) ? 1 / result : result;
        }


    }
}
