// 0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.Write("Задай число: ");
int number = Convert.ToInt32(Console.ReadLine());
int kvadrat = number * number;
Console.WriteLine($"{number} в квадрате равно {kvadrat}");