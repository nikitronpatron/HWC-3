// На ввод: пятизначное число
// На вывод: палиндром? да/нет

void FindPalindrome (int number)
{
    if (number > 9999 && number < 100000)
    {
        int one = number % 10;
        int ten = number / 10 % 10;
        int hundred = number / 100 % 10;
        int thousand = number / 1000 % 10;
        int tenThousand = number / 10000 % 10;
        if (one == tenThousand && ten == thousand)
        {
            Console.WriteLine($"{number} is a palindrome");
        }
        else
        {
            Console.WriteLine($"{number} isn`t a palindrome");
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}
Console.WriteLine("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindPalindrome(number);