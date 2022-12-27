// Задача 50
// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Task #50");

Console.Write("Input the number of lines: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input the number of columns: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5;
int m = 7;

Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Massiv: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();

}
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("The elements is doesn exist");
}
else
{
    Console.WriteLine("The value of element = {0}", arr[pos1, pos2]);
}
Console.ReadLine();