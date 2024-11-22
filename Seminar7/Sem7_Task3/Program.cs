// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание использовать рекурсию. Не использовать цикл.
// Пример:
// "hello" => hll
// "World" => Wrld
// "hello world!" => Hllwrld

static void CheckPrintConsonats(string txt, int index)
{
string vowels = "aeiouy";
if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index]))
{
Console.Write($"{txt[index]}");
}
}

void PrintConsonants(string txt, int index = 0)
{
if (index == txt.Length)
{
return;
}
CheckPrintConsonats(txt, index);
PrintConsonants(txt, index + 1);
}

Console.WriteLine("введите строку содержащую латинские буквы: ");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text);