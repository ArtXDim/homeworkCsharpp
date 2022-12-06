/* ## Задача 2: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7 
44 5 78 -> 78
22 3 9 -> 22
*/


//Решение №1 через IF

Console.WriteLine("Input number a=");
int a = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number b=");
int b = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number c=");
int c = Convert.ToInt32(Console.ReadLine() ??"");
int max = 0;

max = a;
if ((b > a) & (b > c))
{
    Console.WriteLine($"max = {b}");
}
else if ((c > b) & (c > a))
{
   Console.WriteLine($"max = {c}");
}
else
{
    Console.WriteLine($"max = {a}");
}

//Решение №2 Через двойную Math.max

Console.WriteLine("Input number A=");
int numa = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number B=");
int numb = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number C=");
int numc = Convert.ToInt32(Console.ReadLine() ??"");

int max3 = Math.Max(numa, Math.Max(numb,numc));
Console.Write($"max = {max3}");

