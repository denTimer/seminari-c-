// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.

Console.Clear();

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Выпало число: {number}");

int first = number / 100;
int last = number % 10;

System.Console.WriteLine($"Первая цифра - {first}");
System.Console.WriteLine($"Последняя цифра - {last}");
System.Console.WriteLine($"Сумма первой и последней цифр - {first+last}");