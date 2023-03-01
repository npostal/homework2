// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}\n");
int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine("Первое решение");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}\n");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}\n");
}

Console.WriteLine("Второе решение");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {result}\n");

Console.WriteLine("Третье решение");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}