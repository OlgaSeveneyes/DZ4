Console.Clear();
int num0 = NumberFromUser ("Введите первое число массива: ","Ошибка ввода!");
int num1 = NumberFromUser ("Введите второе число массива: ", "Ошибка ввода!");
int num2 = NumberFromUser ("Введите третье число массива: ", "Ошибка ввода!");
int num3 = NumberFromUser ("Введите четвертое число массива: ", "Ошибка ввода!");
int num4 = NumberFromUser ("Введите пятое число массива: ", "Ошибка ввода!");
int num5 = NumberFromUser ("Введите шестое число массива: ", "Ошибка ввода!");
int num6 = NumberFromUser ("Введите седьмое число массива: ", "Ошибка ввода!");
int num7 = NumberFromUser ("Введите восьмое число массива: ", "Ошибка ввода!");

int [] array = {num0, num1, num2, num3, num4, num5, num6, num7};
Console.WriteLine($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");

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