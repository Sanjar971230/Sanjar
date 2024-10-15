// Данно натуральное трёхзначное число. Сщздайте массив, состоящий из цифр этого числа.
// Младший разряд числа должен располагаться на 0-м индексе массива, старщий на 2-м.
// пример: 
// 456 => [6, 5, 4]
// 781 => [1, 8, 7]



Console.Write("Введите трёх значное число");
int num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int count = 0;

// счетает колличество цифр в числе
while(numCopy !=0)
{
    numCopy /= 10;
    count++;
}

// 
int[] arr = new int [count]; // создаем массив на колличество цифр
int index = 0; // индекс последнего элемента
while (num != 0)
{
    arr[index] = num % 10;
    num /= 10; // num = num / 10;
    index++;
}
Console.Write("[");
for(int i =0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}");
}
Console.Write("]");



