// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

System.Console.Write("Задай первое число: ");
int number_first = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задай второе число: ");
int number_second = Convert.ToInt32(Console.ReadLine());

if (number_second * number_second == number_first)
{
    System.Console.WriteLine($"Число {number_first} это {number_second} в квадрате");
}
else
{
    System.Console.WriteLine($"Число {number_first} это не {number_second} в квадрате");
}