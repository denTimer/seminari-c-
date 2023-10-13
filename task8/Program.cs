// На вход поступает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

using System;

int number = new Random().Next(1, 10);
System.Console.WriteLine("Выпало число: " + number);

        for (int i = 1; i < number + 1; i++)
    {
        if(i % 2 == 0)
            Console.Write(i +"\t");
    }
    