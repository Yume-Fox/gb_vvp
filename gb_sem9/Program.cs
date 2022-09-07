// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите начальное число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число: ");
int last = int.Parse(Console.ReadLine());
Console.WriteLine(ShowNumbers(first, last));

int ShowNumbers(int start, int end)
{
    if(start == end) return start;
    Console.Write($"{start} ");
    return ShowNumbers(start + 1, end);
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите начальное число: ");
// int first = int.Parse(Console.ReadLine());
// Console.Write("Введите последнее число: ");
// int last = int.Parse(Console.ReadLine());

// int result = SumNumbers(first, last);
// Console.WriteLine(result);

// int SumNumbers(int start, int end)
// {
//     return start == end ? end : SumNumbers(start + 1, end) + start;
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// int result = Akkerman(2, 3);
// Console.WriteLine(result);

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if ((m != 0) && (n == 0))
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m,  n- 1));
// }