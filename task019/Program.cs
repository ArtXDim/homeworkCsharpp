// Задача №19:__
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Решение №1

int GetNumber(string message)
//body function
{
    //bool isCorrect = false; // bool - принимает булиевая переменная true false. 
    while (true)
    {
        Console.WriteLine(message);
        string number = Console.ReadLine() ?? "";
        if (int.TryParse(number, out int result) && 9999 < result && result < 100000)
        //if (number.Length == 5 && int.TryParse(number, out int result) && result > 0)
        {
            return result; //break; //isCorrect = true;
        }
        else
        {
            Console.WriteLine("Wrong input. Please input correct number");
        }
    }

}

bool IsPalindrom(string number)
{
    return (number[0] == number[4] && number[1] == number[3]);
}

int number = GetNumber("Input your fives-number value");
if (IsPalindrom(number.ToString()))
{
    Console.WriteLine($"Your number: {number} - palindrom.");
}
else Console.WriteLine($"Your number: {number} - not palindrom.");
