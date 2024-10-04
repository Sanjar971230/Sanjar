// Напишите программу, которая будет принимать на вход два числа и выводить, являеться ли первое число кратным второму.
// Если первое число не кратное второму, то программа выводит остаток от деления.
// Пример:
// 14,5 => нет 4
// 16,8 +> да
// 4,3  +> нет 1


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;

if (result == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Нет " + result);
}
