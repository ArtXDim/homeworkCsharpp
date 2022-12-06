/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Input value a=");
int numA = Convert.ToInt32(Console.ReadLine() ??"");
Console.Write("Input value b=");
int numB = Convert.ToInt32(Console.ReadLine() ??"");

if (numA > numB)
{
   Console.WriteLine($"max = {numA}");
}
else if (numA == numB)
{
   Console.WriteLine($"{numA} = {numB}"); 
}
else
{
    Console.WriteLine($"max = {numB}");
}