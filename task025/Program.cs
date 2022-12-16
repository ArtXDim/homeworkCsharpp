// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Task #25");

int Expone(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)   
    {
        result = result * a;
    }
    return result;
}

Console.Write("Input number a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b:");
int b = Convert.ToInt32(Console.ReadLine());
int Exponention = Expone(a, b);
Console.WriteLine($"a^(b) = {Expone(a, b)}");




