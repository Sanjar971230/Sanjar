// Задача 1: 
// Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

// static void PrintNumbers(int M, int N)
// {
//     if (M > N) return;
//     Console.Write(M + " ");
//     PrintNumbers(M + 1, N);
// }

// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Натуральные числаот M до N:");
// PrintNumbers(M, N);




// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         int result = Ackermann(m, n);
//         Console.WriteLine($"A({m}, {n}) = {result}");
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (m > 0 && n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }


// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10


// int[] array = { 1, 2, 3, 4, 5 };

// PrintArrayReverse(array, array.Length - 1);

// static void PrintArrayReverse(int[] array, int index)
// {
//     if (index < 0)
//     {
//         return;
//     }
//     Console.Write(array[index] + " ");
//     PrintArrayReverse(array, index - 1); 
// }

