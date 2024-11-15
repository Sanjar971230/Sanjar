// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// static string CharArrayToString(char[,] array)
// {
//     string result = string.Empty;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j];
//         }
//     }
//     return result;
// }

// char[,] charArray = { { 'H', 'e', 'l', 'l', 'o' }, { 'W', 'o', 'r', 'l', 'd' } };
// string result = CharArrayToString(charArray);  // Преобразуем массив символов в строку
// Console.WriteLine(result);




// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.WriteLine("Введите строку:");
// string input = Console.ReadLine();
// string result = ConvertToLowerCase(input);
// Console.WriteLine("Преобразованная строка:");
// Console.WriteLine(result);

// static string ConvertToLowerCase(string str)
// {
//     return str.ToLower();
// }




// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Console.WriteLine("Введите строку:");
// string input = Console.ReadLine();
// bool isPalindrome = IsPalindrome(input);

// if (isPalindrome)
// {
//     Console.WriteLine("Строка является палиндромом.");
// }
// else
// {
//     Console.WriteLine("Строка не является палиндромом.");
// }

// static bool IsPalindrome(string str)
// {
//     string cleanedStr = string.Concat(str.Where(char.IsLetterOrDigit)).ToLower();
//     string reversedStr = new string(cleanedStr.Reverse().ToArray());
//     return cleanedStr == reversedStr;
// }


