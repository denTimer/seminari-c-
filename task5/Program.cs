// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
        
        // Выводим все целые числа от -N до N
        for (int i = -N; i <= N; i++)
        {
            Console.Write(i +"\t");
        }
    }
}
