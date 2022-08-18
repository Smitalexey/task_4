using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите любое целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int SumNumber(int number)
        {
            int count = Convert.ToString(number).Length;
            int newCount = 0;
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                newCount = number - number%10;
                result = result + (number - newCount);
                number = number/10;
            }
            return result;
        }
            int sumNumber = SumNumber(number);
            Console.WriteLine("Сумма цифр в числе = " + sumNumber);
    }
}