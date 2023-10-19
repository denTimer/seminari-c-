// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

System.Console.Write("Задай первое число:");
int number_first = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задай второе число:");
int number_second = Convert.ToInt32(Console.ReadLine());

if (number_first * number_first == number_second)
{
    System.Console.WriteLine("Число " + number_second + " это " + number_first + " в квадрате");
}
else
{
    System.Console.WriteLine("Число " + number_second + " это не " + number_first + " в квадрате");
}