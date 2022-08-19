// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Первый вариант решения
// double exponentiation(double a, double b)
// {
//     return Math.Pow(a, b);
// }

// Второй вариант решения
double exponentiation(double a, double b)
{
    double result = 1;
    for (double i = 0; i < b; i++)
    {
        result = a*result;
    }
    return result;
}

Console.Write("Введите число А: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {exponentiation(numA, numB)}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = num;
// int result = 0;
// int[] arr = new int[amountNum(num)];

// for (int i = 0; i != arr.Length; i++) // записываем значения в массив
// {
//     res %= 10;
//     num /= 10;
//     arr[i] = res;
//     res = num;
// }

// // складываем значения массива
// for (int j = 0; j != arr.Length; j++)
// {
//     result = arr[j] + result;
// }

// Console.WriteLine(result);

// int amountNum(int a) // считаем количество символов в введенном числе
// {
//     int i = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         i++;
//     }
//     return i;
// }