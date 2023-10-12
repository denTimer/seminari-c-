// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

using System;

class Program
{
    static void Main()
    {
    string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    
    Console.WriteLine ("Введите номер дня недели");
    int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    string dayOfWeek = daysOfWeek[number - 1];
    Console.WriteLine(dayOfWeek);
}
else
{
    Console.WriteLine("Неверный номер дня недели");
}
}    
}