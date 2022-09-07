// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[5,5];
FillArray(array, 0, 10);
SortedEveryStringArray(array);
Console.WriteLine();
PrintArray(array);

void SortedEveryStringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(0); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[] sumArray = CalcSumInEachRow(FillArray(6, 4, 0, 10));
// Console.WriteLine();
// FindMinSumInArray(sumArray);

// int[] CalcSumInEachRow(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     int sum;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         sumArray[i] = sum;
//         Console.WriteLine($"Сумма строки {i + 1} = {sumArray[i]}");
//     }

//     return sumArray;
// }

// void FindMinSumInArray(int[] array)
// {
//     int min = array[0];
//     int minIndex = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             minIndex = i;
//         }
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов: Строка {minIndex + 1}");
// }

// int[,] FillArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// } 

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] firstM = {{2, 4}, {3,2}};
// int[,] secondM = {{3,4}, {3,3}};
// int[,] matrix2x2 = MultiplyMatrix(firstM, secondM);
// PrintArray(matrix2x2);
// Console.WriteLine();

// Console.WriteLine("Создание первой матрицы");
// int[,] firstMatrix = FillArray(5, 0, 10);
// Console.WriteLine("Создание второй матрицы");
// int[,] secondMatrix = FillArray(5, 0, 10);
// int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);
// PrintArray(result);

// int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     int size = firstMatrix.GetLength(0);
//     int[,] resultArray = new int[size, size];

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for(int k = 0; k < size; k++)
//             {
//                 resultArray[i,j] += firstMatrix[i, k] * secondMatrix[k, j];
//             }
//         }
//     }
//     return resultArray;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FillArray(int size, int minValue, int maxValue)
// {
//     int[,] array = new int[size, size];
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Fill3DArray(3);

// bool HasSameValueInArray(int[,,] array, int value)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == value) 
//                 {
//                     // Console.WriteLine($"значение {value} уже есть в массиве"); для понимания
//                     return true;
//                 }
//             }
//         }
//     }
//     return false;
// }

// void Fill3DArray(int size)
// {
//     int[,,] array = new int[size, size, size];
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for (int k = 0; k < size; k++)
//             {
//                 int rndValue;
//                 do
//                 {
//                     rndValue = new Random().Next(10, 100);
//                 }
//                 while (HasSameValueInArray(array, rndValue));
//                 array[i, j, k] = rndValue;

//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] array = SpiralArray(4);
// PrintArray(array);

// int[,] SpiralArray(int size)
// {
//     int[,] array = new int[size, size]; 

//     int i = 0, j = 0; 
//     int count = 1; 

//     while (size != 0)
//     {
//         for(int k = 0; k < size - 1; k++) 
//         {
//             array[i, j++] = count++;
//         }
//         for (int k = 0; k < size - 1; k++) 
//         {
//             array[i++, j] = count++;
//         }
//         for (int k = 0; k < size - 1; k++) 
//         {
//             array[i, j--] = count++;
//         }
//         for (int k = 0; k < size - 1; k++) 
//         {
//             array[i--, j] = count++;
//         }

//         size = size < 2 ? 0 : size - 2; 
//         i++; 
//         j++; 
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,4}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }