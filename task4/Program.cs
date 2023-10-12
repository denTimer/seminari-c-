// На вход поступает три числа и выдаётся максимальное из этих чисел.

using System;

System.Console.WriteLine("Введите первое число");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());

    int max = firstNumber;
        if (max < secondNumber)
        {
            max = secondNumber;
        }
        if (max < thirdNumber)
        {
            max = thirdNumber;
        }
            
        System.Console.WriteLine("Максимальное число = " + max);
