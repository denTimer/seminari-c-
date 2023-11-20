
/*Console.Clear();

//Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
Console.WriteLine("кратно");
}
else
{
Console.WriteLine("не кратно");
}


System.Console.Write("Задай первое число: ");
int number_first = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задай второе число: ");
int number_second = Convert.ToInt32(Console.ReadLine());

if (number_second * number_second == number_first || number_first * number_first == number_second)
{
    System.Console.WriteLine("Выполняется");
}
else
{
    System.Console.WriteLine("Не выполняется");
}
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        int number = int.Parse(Console.ReadLine());
        
        string digits = number.ToString();
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Length - 1)
            {
                Console.Write(",");
            }
        }
    }
}