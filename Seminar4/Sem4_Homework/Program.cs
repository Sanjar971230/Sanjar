// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



// while (true)
// {
//     Console.WriteLine("Введите целое число (или 'q' для выхода):");
//     string input = Console.ReadLine();

//     if (input == "q")
//     {
//         break;
//     }

//     if (int.TryParse(input, out int number))
//     {
//         int sumOfDigits = 0;
//         while (number != 0)
//         {
//             sumOfDigits += number % 10;
//             number /= 10;
//         }

//         if (sumOfDigits % 2 == 0)
//         {
//             break;
//         }
//     }
// }





// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.



// int[] array = CreateArrayRndInt(10, 100, 1000); // Создаём массив из 10 случайных трёхзначных чисел
// PrintArray(array); // Печатаем массив
// int evenCount = CountEvenNumbers(array); // Считаем количество чётных чисел
// Console.WriteLine($"\nКоличество чётных чисел: {evenCount}");


// static int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }
//     return array;
// }

// static void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else
//         {
//             Console.Write($"{array[i]}");
//         }
//     }
//     Console.Write("]");
// }

// static int CountEvenNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int number in array)
//     {
//         if (number % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }





// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)



int[] array = { 1, 2, 3, 4, 5 };
PrintArray(array); // Исходный массив
ReverseArray(array); // Переворачиваем массив
PrintArray(array); // Перевёрнутый массив

static void ReverseArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[length - 1 - i];
        array[length - 1 - i] = temp;
    }
}

static void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

