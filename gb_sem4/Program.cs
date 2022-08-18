// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double exponentiation(double a, double b)
// {
//     return Math.Pow(a, b);
// }

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
Console.WriteLine(exponentiation(numA, numB));

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// amountNum(num);

// void amountNum (int a){
//     int i = 0;
//     while (a > 0) {
//         a /= 10;
//         i++;
//     }
//     Console.WriteLine($"Количество цифр: {i}");
// }