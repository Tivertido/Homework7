﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[m, n]; // Создаем двумерный массив

        // Заполняем массив случайными числами
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
        }

        // Выводим массив на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }