using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите два целых числа ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Число а в степени b равно ");
        Console.WriteLine(Math.Pow(a,b));

    }
}