using System;
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
namespace Semin2
{
    class Program
    {
        static int NewNumber = 0;
        static int SecondNumber(int Number)
        {
            NewNumber = (Number % 100 - Number % 10)/10;
            return NewNumber;
        }
        static void Main(string[] args) {
        Console.WriteLine("Введите трехзначное число:");
        int chislo = int.Parse(Console.ReadLine());
        int result = SecondNumber(chislo);
        Console.WriteLine($"Вторая цифра числа {chislo} это: {result}");
        }
    }
}
