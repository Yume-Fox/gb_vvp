// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] arr = new double[3, 4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(10, 99), 2);
//         Console.Write($"{arr[i, j]}\t");
//     }
//     Console.WriteLine();
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите номер строки: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
// if (n >= arr.GetLength(0) || m >= arr.GetLength(1)) { Console.WriteLine("Индекс отсутствует"); }
// else
// {
//     int result = arr[m, n];
//     Console.WriteLine(result);
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = GenerationArray();
for (int i = 0; i < arr.GetLength(0); i++)
{
    double result = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        result += arr[j, i];
    }
    result /= arr.GetLength(0);
    Console.Write($"{result:f1}\t");
}

int[,] GenerationArray()
{
    int[,] arr = new int[3, 3];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}