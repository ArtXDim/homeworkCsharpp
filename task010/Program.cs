/*
Задача №10
Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Input three-digit number");
int numA = Convert.ToInt32(Console.ReadLine() ??"");

Console.WriteLine((numA % 10));
