/* 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.Clear();

int number = new Random().Next(100, 1000);
System.Console.WriteLine("Выпало число: " + number);

int last = number % 10;

System.Console.WriteLine("Последняя цифра - " + last);
