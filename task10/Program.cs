/* 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

System.Console.Write("Введи трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000)
{
    num = num / 10 % 10;
    System.Console.Write("Вторая цифра: " + num);
}
else
{
System.Console.Write("Число " + num + " не трехзначное");
}