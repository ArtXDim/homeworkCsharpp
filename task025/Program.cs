// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Task #25");

int GetNumber(string message)
{
    //bool isCorrect = false; // bool - принимает булиевая переменная true false. 
    while (true)
    {
        Console.WriteLine(message);
        string number = Console.ReadLine() ?? "";
        if (int.TryParse(number, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Wrong input. Please input correct number");
        }
    }
}

Get

Console.Write("Input number a=");
int a = Convert.ToInt32(Console.ReadLine() ??"");
Console.Write("Input number b=");
int b = Convert.ToInt32(Console.ReadLine() ??"");
int result = 0;

Console.WriteLine($"{Math.Pow(a,b)}");




