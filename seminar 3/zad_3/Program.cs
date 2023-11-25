// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


double[] numbers = new double[] { 3.5, 8.7, 12.9, 17.2, 20.6, 25.1, 30.4, 35.8, 40.3, 45.0 };
            double min = numbers[0];
            double max = numbers[0];

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }

            double difference = max - min;
            Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);