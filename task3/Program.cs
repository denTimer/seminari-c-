// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    string dayOfWeek = daysOfWeek[number - 1];
    Console.WriteLine("Это " + dayOfWeek);
}
else
{
    Console.WriteLine("Неверный номер дня недели");
}
