// Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");

int SecondDigit(int num)
{
    int firstNumber = num % 100;
    int result = firstNumber / 10;
    return result;
}