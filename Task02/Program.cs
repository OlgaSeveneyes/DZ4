Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
Console.WriteLine($"Cумма цифр в числе {num} -> {GetSumDigits(num)}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetSumDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
