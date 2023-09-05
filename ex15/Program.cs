using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int finishNumber = 28;
            int minNumber = 100;
            int maxNumber = 1000;
            int result = 0;

            Random random = new Random();
            int number = random.Next(startNumber, finishNumber);
            Console.WriteLine($"Число N: {number}");

            for (int i = 0; i < maxNumber; i += number)
            {
                if (i >= minNumber)
                {
                    Console.WriteLine($"Кратное число: {i}");
                    result++;
                }
            }

            Console.WriteLine($"Кол-во натуральных трехзначных чисел: {result}");
        }
    }
}
