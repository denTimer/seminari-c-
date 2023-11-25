int number = 245631; // Здесь можно указать любое натуральное число от 1 до 100000
            int numLength = (int)Math.Floor(Math.Log10(number) + 1); // Определение количества цифр в числе
            int[] digitsArray = new int[numLength]; // Создание массива

            for (int i = numLength - 1; i >= 0; i--)
            {
                digitsArray[i] = number % 10; // Заполнение массива цифрами числа
                number /= 10; // Удаление последней цифры числа
            }

            Console.WriteLine("Массив цифр числа:");
            foreach (var digit in digitsArray)
            {
                Console.Write(digit + " ");
            }