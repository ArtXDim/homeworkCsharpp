// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Input number ");
int a = Convert.ToInt32(Console.ReadLine() ?? "");

if ((a >= 100) && (a <= 999))
{
    Console.WriteLine($"The third digit is {a % 10} ");
}
else if (a < 100)
{
    Console.WriteLine("!!! No third digit");
}
else if (a > 999)
{
    Console.WriteLine("!!! This is not third-digit number");
}