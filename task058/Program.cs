// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:

// 18 20
// 15 18


Console.Clear();
Console.WriteLine("Task #58");

Console.WriteLine($"\nInput size of matrix and range of random numbers:");
int m = InputNumbers("Input number of string first matrix: ");
int n = InputNumbers("Input number of columns first matrix (and strings second matrix): ");
int p = InputNumbers("Input number of columns second matrix: ");
int range = InputNumbers("Input range of random numbers: form 1 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nFirst matrix:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"\nSecond matrix:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nProduct first and second matrix:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}