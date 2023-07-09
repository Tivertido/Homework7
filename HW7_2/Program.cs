﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        Console.WriteLine("Введите позицию элемента в двумерном массиве (i, j):");

        // Считываем позицию элемента от пользователя
        string position = Console.ReadLine();
        string[] positionArr = position.Split(',');

        // Парсим позицию в целочисленные значения
        int i = int.Parse(positionArr[0]);
        int j = int.Parse(positionArr[1]);

        // Проверяем, что позиция находится в пределах массива
        if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
        {
            // Получаем значение элемента
            int value = array[i, j];
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Такого элемента не существует.");
        }