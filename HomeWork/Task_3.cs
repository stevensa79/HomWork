
    
        int[] arr = new int[90];
        
        // Присваиваем значения от 10 до 99
        for (int i = 0; i < 90; i++)
        
        {
            arr[i] = i + 10;
        }

        // Находим максимальное значение
        int max = arr[0]; // Предполагаем, что первый элемент - максимальный
        Console.WriteLine("Massive Numbers: 10_to_99");

        for (int i = 1; i < 90; i++)

        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            
            Console.Write($"{arr[i]}\t");
        }

        // Выводим максимальное значение
        Console.WriteLine("\nMaximum Number in massive: " + max);
   

