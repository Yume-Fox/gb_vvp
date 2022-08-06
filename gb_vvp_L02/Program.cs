/* int num1 = 5;
int num2 = 3;
Console.Write("Результат: " + (num1 + num2)); */


/* int num1 = new Random().Next(1, 35);
Console.WriteLine("Первое число: " + num1);
int num2 = new Random().Next(1, 35);
Console.WriteLine("Второе число: " + num2);
Console.Write("Результат: " + (num1 + num2)); */


Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "мария") {
    Console.Write("Омай гарбл, Данила! Это же " + username);
}
else {
    Console.Write("Привет, " + username);
}