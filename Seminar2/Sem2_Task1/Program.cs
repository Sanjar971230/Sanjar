// Напиши программу которая принимает на вход трех значное число и удаляет вторую цифру этого числа.
// Примеры: 
// а = 256 => 26
// a = 891 => 81



Console.Write("Введите трехзначное число");
int sum = Convert.ToInt32(Console.ReadLine());

if (sum >= 100 && sum <= 999)
{
    int firstDigit = sum / 100; // 256/100 = 2.56 = 2
    int thirdDigit = sum % 10;  // 256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}