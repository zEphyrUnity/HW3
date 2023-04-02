int GetUserData()
{
    int userNumber;

    Console.WriteLine("Введите число");
    while (!int.TryParse(Console.ReadLine(), out userNumber))
    {
        Console.WriteLine("Введите число, а не строку!");
    }
    return  Math.Abs(userNumber);
}

bool IsPalindromeNumber(float userNumber)
{
    int numberDigits = 0;
    float remainder = userNumber;
    int userNumberTemp = (int)userNumber;
    bool isPalindorme = true;

    while (remainder > 1)
    {
        remainder /= 10;
        numberDigits++;
    }

    int counter = numberDigits / 2;
    for (int i = 0; i < counter; i++)
    {
        int firstCompare = (int)userNumber;
        int secondCompare ;

        for(int j = 0; j < numberDigits - 1; j++)
        {
            firstCompare /= 10;
        }

        secondCompare = userNumberTemp % 10;
        userNumberTemp /= 10;
        Console.WriteLine($"userNumberTemp {userNumberTemp}");

        Console.WriteLine(firstCompare % 10);
        Console.WriteLine(secondCompare);

        if(secondCompare != (firstCompare % 10))
        {
            isPalindorme = false;
        }

        numberDigits -= 1;
    }

    Console.WriteLine(isPalindorme);
    return isPalindorme;
}

int userNumber = GetUserData();
bool isPlaindrome = IsPalindromeNumber(userNumber);

if (isPlaindrome)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{userNumber} является палиндромом!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{userNumber} не является палиндромом!");
}

Console.ForegroundColor = ConsoleColor.White;

