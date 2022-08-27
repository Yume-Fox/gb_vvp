// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел, которое хотите ввести: ");
int num = Convert.ToInt32(Console.ReadLine());

countNumber(newArray(num));

int[] newArray(int a)
{

    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void countNumber(int[] a)
{
    int[] arr = a;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} положительных числа");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// CrossingOfLine(b1, b2, k1, k2);

// void CrossingOfLine(double b1, double b2, double k1, double k2)
// {
//     if (k1 == k2 && b1 == b2) 
//     {
//         Console.WriteLine("Линии нахрдятся на одной прямой");
//         return;
//     }
//     else if (k1 == k2) 
//     {
//         Console.WriteLine("Линии параллельны");
//         return;
//     }
//     else 
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = (k1 * x + b1);
//         Console.Write(x + "; " + y); 
//     }
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////