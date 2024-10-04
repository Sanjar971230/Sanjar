// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10,       => нет
// a = 9, b = -3        => да
// a = -3, b = 9        => нет

// string sum1 = Console.ReadLine();
// int sum = Convert.ToInt32(sum1);

Console.Write("Введите первое число");
int sum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int sum2 = Convert.ToInt32(Console.ReadLine());

if (sum1 == sum2 * sum2)
{
    Console.WriteLine("Первое число являеться квадратом второго");
}
else
{
    Console.WriteLine("Первое число не являеться квадратом второго");
}
