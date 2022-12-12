// Задача 15:__
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Решение 

using System;

int numberWeek(string message)
//body function
{
    //bool isCorrect = false; // bool - принимает булиевая переменная true false. 
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 8)
        {
            return result; //break; //isCorrect = true;
        }
        else
        {
            Console.WriteLine("Wrong input. Please input correct number");
        }
    }

}

void numberWeek1(int NumWeek)
{
    if (Math.Abs(NumWeek) <= 5)
    {
        Console.Write("This is a weekday");
    }
    else if ((NumWeek == 6) || (NumWeek == 7))
    {
        Console.WriteLine("This is a day off");
    }
}
int number = numberWeek("Input number the day of a week");
numberWeek1(number);


// Решение №2

Console.WriteLine("Input number the day of a week");
int day = Convert.ToInt32(Console.ReadLine() ?? "");

switch (day)    //метод switch конструкция
{
    case 1:
        Console.WriteLine("The first day in week is Monday");
        break;

    case 2:
        Console.WriteLine("The first day in week is Monday");
        break;

    case 3:
        Console.WriteLine("The third day in week is Wednesday");
        break;

    case 4:
        Console.WriteLine("The fourth day in week is Thursday");
        break;

    case 5:
        Console.WriteLine("The fifth day in week is Friday");
        break;

    case 6:
        Console.WriteLine("The sixth day in week is Saturday");
        break;

    case 7:
        Console.WriteLine("The seventh day in week is Sunday");
        break;

    default:
        Console.WriteLine("In week we have only seven days. You introduced a wrong number!!!");
        break;
}
if (Math.Abs(day) <= 5)
{
    Console.Write("This is a weekday");
}
else if ((day == 6) || (day == 7))
{
    Console.WriteLine("This is a day off");
}
