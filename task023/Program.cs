// Задача 23:
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("\n Task#23");
Console.Write("Input number: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);

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