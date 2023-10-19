using System;
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        // Выводим все целые числа от -N до N
        for (int i = -N; i <= N; i++)
        {
            Console.Write(i +"\t");
        }

