// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] numbers = new int[] { 3, 8, 12, 17, 20, 25, 30, 35, 40, 45 };
            int count = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество чётных чисел в массиве: " + count);