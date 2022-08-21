int numA = NumberFromUser ("Введите число: ","Ошибка ввода!");
int numN = NumberFromUser ("Введите степень числа: ", "Ошибка ввода!");
int gradeNumber = GetGradeNumber(numA, numN);
Console.WriteLine($"\t{numA} в степени {numN} -> {gradeNumber}");

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetGradeNumber(int numberA, int numberN)
{
    int count = 1;
    int gradeNum = 1;
    while(count <= numberN)
    {
        gradeNum = gradeNum*numberA;
        count++;
    }
    return gradeNum;
}