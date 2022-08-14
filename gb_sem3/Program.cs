
Console.WriteLine("1 - Проверка на палиндромность\n2 - Координаты 2х точек в 3D пространстве\n3 - Куб числа от 1 до N");
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1: Palindrome(); break;
    case 2: TwoPoint(); break;
    case 3: NumberCubed(); break;
    default: Console.WriteLine("Такой задачи не существует"); break;
}


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome()
{
    Console.Clear();
    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[5];
    int res = num;

    for (int i = 0; i != arr.Length; i++)
    {
        num = res;
        arr[i] = num %= 10;
        res /= 10;
    }

    if (arr[0] == arr[4] && arr[1] == arr[3]) { Console.WriteLine("Да"); }
    else { Console.WriteLine("Нет"); }
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void TwoPoint()
{
    Console.Clear();
    Console.Write("Введите координату X первой точки: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату X второй точки: ");
    int xb = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Y первой точки: ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y второй точки: ");
    int yb = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Z первой точки: ");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z второй точки: ");
    int zb = Convert.ToInt32(Console.ReadLine());

    double l = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    Console.WriteLine($"Расстояние между точками: {l}");
}

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void NumberCubed()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i * i * i);
    }
}

