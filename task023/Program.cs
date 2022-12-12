// Задача 23:
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result; //break; //isCorrect = true;
        }
        else
        {
            Console.WriteLine("Wrong input. Please input number");
        }
    }

}

decimal GetMultiply(int number)
{
    decimal result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = (decimal)Math.Pow(i, 3);
    }
    Console.WriteLine($" {result}");
    return(result);
}

int number = GetNumber("Input value N ");
GetMultiply(number);
Console.WriteLine($" {number} ");
