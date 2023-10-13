/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

System.Console.Write("Введи номер дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    System.Console.Write("Это рабочий день");
}
if (num >= 6 && num <= 7)
{
    System.Console.Write("Это выходной");
}
if (num < 1 || num > 7)
{
  System.Console.Write("Нет такого дня недели");  
}