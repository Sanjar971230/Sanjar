﻿// Задайте массив из 10 элементов, заполнеными числами из промежутка [-10, 10].
// Замените отрицательное элементы на положительные, а положительные на отрицательные. 
// Пример: 

// [1, -5, 6]  => [-1, 5, -6]


int[] array = [1, -2, 3, 4, -5, -6, 8, -7, 9, 10];

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] = array[i] *= -1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}




