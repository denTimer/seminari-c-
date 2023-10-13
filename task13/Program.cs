/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());

if (num < 0) 
{ 
num = num * -1;
}
if (num > 99)
{
    for (int i = num; i > 99; i /= 10)
    {
        num = i;
    }
    System.Console.WriteLine($"Третья цифра {num % 10}");
}
else System.Console.WriteLine("Нет третьей цифры");