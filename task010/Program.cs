/*
Задача №10
Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//Решение №1

Console.Clear();
Console.WriteLine("Input three-digit number");
int numA = Convert.ToInt32(Console.ReadLine() ?? "");

Console.WriteLine($"The third digit is {numA / 10 % 10}");

//Решение №2

Console.WriteLine("Input three-digit number");
int ThirdNum = Convert.ToInt32(Console.ReadLine() ?? "");
string StrThirdNum = (Convert.ToString(ThirdNum));

Console.WriteLine($"The third digit is {StrThirdNum[1]}");