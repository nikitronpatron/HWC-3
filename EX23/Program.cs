// На вход: число (N)
// На выход: таблица кубов чисел от 1 до N

void SquareIt (int number)
{
    if (number > 0)
    {
        for (int i = 1; i < number; i++)
        {
            int square = i * i * i;
            Console.Write($"{square}, ");
        }
        int squareLast = number * number * number;
        Console.WriteLine($"{squareLast}.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error");
        Console.ResetColor();
    }
}

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareIt(number);