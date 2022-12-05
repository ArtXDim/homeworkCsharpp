/* ## Задача 2: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7 
44 5 78 -> 78
22 3 9 -> 22
*/


//Решение №1 через IF
/*
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

//Решение №2 Через двойную мат.функцию максимального Math.max

Console.WriteLine("Input number numA=");
int numa = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number numB=");
int numb = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number numC=");
int numc = Convert.ToInt32(Console.ReadLine() ??"");

int max3 = Math.Max(numa, Math.Max(numb,numc));
Console.Write($"max = {max3}");*/

//Решение №3 Массив

int[] arr = {};
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);

Console.WriteLine("max = " + arr.Max());
