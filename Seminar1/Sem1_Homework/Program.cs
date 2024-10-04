// Задание 1
// Определите, делится ли число на другое Описание:
// Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе выводите "не делится.

// using System.ComponentModel;

// Console.Write("Введите первое число");
// int sum1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число");
// int sum2 = Convert.ToInt32(Console.ReadLine());

// if (sum1 % sum2 == 0) 
// {
//     Console.WriteLine("Делиться");
// }
// else
// {
//     Console.WriteLine("Не делиться");
// }



// Задание 2
// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает среднее из этих чисел (то есть не самое большое и не самое маленькое).
// Пример использования: На входе:
// ● a: 5
// ● b: 3   ответ 5
// ● c: 8

// Console.Write("Введите первое число");
// int sum1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число");
// int sum2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите трете число");
// int sum3 = Convert.ToInt32(Console.ReadLine());

// if ((sum1 > sum2 && sum1 < sum3) || (sum1 > sum3 && sum1 < sum2))
// {
//     Console.WriteLine(sum1);
// }
// else if ((sum2 > sum1 && sum2 < sum3) || (sum2 > sum3 && sum2 < sum1))
// {
//     Console.WriteLine(sum2);
// }
// else if ((sum3 > sum1 && sum3 < sum2) || (sum3 > sum2 && sum3 < sum1))
// {
//     Console.WriteLine(sum3);
// }
// else
// {
//     Console.WriteLine("Здесь нет среднего числа");
// }



// Задание 3
// Определение, является ли число положительным
// Описание: Напишите метод, который на вход принимает число и выводит, является ли оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.

// using System.Timers;

// Console.Write("Введите число");
// int sum = Convert.ToInt32(Console.ReadLine());

// if (sum > 0)
// {
//     Console.WriteLine("Положительное" + sum);
// }
// else if (sum < 0)
// {
//     Console.WriteLine("Отрицательное" + sum);    
// }
// else
// {
//     Console.WriteLine("ноль");
// }



// Задание 4
// Вывести нечетные числа
// Описание: Напишите метод, который на вход принимает число (number), а на выходе выводит все нечетные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i+=2)
//      Console.Write("{0} ", i);

