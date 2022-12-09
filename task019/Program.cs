// Задача №19:__
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Решение №1

Console.Write("Input number ");
string number = Console.ReadLine() ??"";

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Your number: {number} - palindrom.");
    }
    else Console.WriteLine($"Your number: {number} - not palindrom.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine("Input right number");