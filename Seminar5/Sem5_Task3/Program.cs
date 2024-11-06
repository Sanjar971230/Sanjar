// Задайте двумерный массив из целлых чисел. Сформируйте новый одномерный массив, 
// состоящий из среднич арифметический значений по строкам двумерного массива.
// Пример: 
// 2 3 4 3
// 4 3 4 1  => [3 3 5]
// 2 9 5 4


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],5}");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double[] GetAverageArrayRows (int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[i] = (double)sum / matrix.GetLength(1);
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

double[] result = GetAverageArrayRows(array2d);
PrintArray(result);
