// Задача 1: Напишите программу, которая на входпринимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,что такого элемента нет.
// Пример: 

// 4 3 1 (1,2) => 9
// 2 6 9 


// int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// Console.Write("Введите номер строки: ");
// int sum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int sum1 = Convert.ToInt32(Console.ReadLine());

// if (sum >= 0 && sum < matrix.GetLength(0) && sum1 >= 0 && sum1 < matrix.GetLength(1))
// {
//     Console.WriteLine($"Значение элемента: {matrix[sum, sum1]}");
// }
// else
// {
//     Console.WriteLine("Такого элемента нет");
// }



// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
// Пример:

// 4 3 1      4 6 2
// 2 6 9  =>  2 6 9
// 4 6 2      4 3 1


// class Program
// {
//     public static void Main()
//     {
//         Program program = new Program();

//         int[,] array2d =
//         {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };


//         program.PrintMatrix(array2d);  // Печатаем исходный массив


//         program.SwapFirstAndLastRows(array2d); // Меняем местами первую и последнюю строки


//         Console.WriteLine("После замены:"); // Печатаем массив после замены строк
//         program.PrintMatrix(array2d);
//     }

//     public void SwapFirstAndLastRows(int[,] matrix)
//     {
//         int lastRowIndex = matrix.GetLength(0) - 1;

//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             int temp = matrix[0, i];
//             matrix[0, i] = matrix[lastRowIndex, i];
//             matrix[lastRowIndex, i] = temp;
//         }
//     }

//     public void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 3: Задайте прямоугольный двумерный массив.Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Пример:

// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 


// class Program
// {
//     public static void Main()
//     {
//         Program program = new Program();

//         int[,] matrix = {
//             { 1, 2, 3, 4 },
//             { 5, 6, 7, 8 },
//             { 9, 10, 11, 12 },
//             { 0, 1, 2, 3 }
//         };

//         program.PrintMatrix(matrix);

//         int minSumRowIndex = program.FindMinSumRow(matrix);

//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
//     }

//     public void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     public int FindMinSumRow(int[,] matrix)
//     {
//         int minSum = int.MaxValue;
//         int minSumRowIndex = -1;

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 sum += matrix[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRowIndex = i;
//             }
//         }

//         return minSumRowIndex;
//     }
// }




