/* ## Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Input number a=");
int a = Convert.ToInt32(Console.ReadLine() ??"");

if (a % 2 == 0)
    {
        Console.WriteLine($"Value ({a}) is even number.");
    }
else
    {
        Console.WriteLine($"Value ({a}) is odd number.");
    }