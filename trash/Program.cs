/*
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result; //break; //isCorrect = true;
        }
        else
        {
            Console.WriteLine("Wrong input. Please input number");
        }
    }

}

int  GetMultiply(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = (int)Math.Pow(i, 3);
    }
    return(result);
}


int number = GetNumber("Input value N ");
Console.WriteLine($"{GetMultiply(number)} ");


int number = ReadInt("Input number: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

Console.WriteLine("Task # 47");
//input correct nimber
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("This is not number. Please input number" ??"");
        }
    }

    return result;
}