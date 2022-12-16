// ## __Задача 27:__
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Task #27");
Console.WriteLine("Input number N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumLenNumber(int n)
{
    int counter = Convert.ToInt32(n);
    int result = 0;
    int advance = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = n - n % 10;
        result = result + (n - advance);
        n = n / 10;
    }
    return result;
}

int Sum = SumLenNumber(n);
Console.WriteLine($"a^(b) = {SumLenNumber(n)}");