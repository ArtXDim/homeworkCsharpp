/* Задача 4: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа 
от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//Решение

Console.WriteLine("Input of value n");
int n = Convert.ToInt32(Console.ReadLine() ??"");

Console.Write($"List of even numbers in between 0 .... {n}:");
for (int i = (1); i <= n; i+=1 )
    if (i % 2 == 0 )
    {
    Console.Write($" {i} ");
    }