using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите размерность массивов (от 2 до 100)  ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = new Random().Next(-100, 100);
            Console.WriteLine("a[{0}] = {1}", i, a[i]);
        }
            Console.ReadKey();
    }
}