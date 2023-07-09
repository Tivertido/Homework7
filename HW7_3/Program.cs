// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        double[] average = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            average[j] = (double)sum / rows;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");

        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"{average[j]}");
        }