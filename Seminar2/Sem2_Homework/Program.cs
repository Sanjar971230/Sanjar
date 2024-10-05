// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.




// Console.WriteLine("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

//  if (num % 7 == 0 && num % 23 == 0)
//         {
//             Console.WriteLine("Число кратно и 7 и 23");
//         }
//         else if (num % 7 == 0)
//         {
//             Console.WriteLine("Число кратно только 7");
//         }
//         else if (num % 23 == 0)
//         {
//             Console.WriteLine("Число кратно только 23");
//         }
//         else
//         {
//             Console.WriteLine("Число не кратно нa 7 ни 23");
//         }




// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.



// Console.WriteLine("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Некоректный кординаты");
// }




// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.



// Console.Write("Введите число с точки [10, 99");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// int maxresult = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine(maxresult);




// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.



// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// while (i <= N)
// {
//     Console.Write(i);
//     Console.Write($" ,");
//     Console.Write(" .");
//     i = i + 1;
// }

