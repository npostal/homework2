//Напишите программу, которая 
//1. выводит случайное трёхзначное число и 
//2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");
int sumDigit = SumDigit(number);

Console.WriteLine($"Число после удаления второй цифры случайного числа -> {sumDigit}");

int SumDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int sumD = firstDigit * 10 + lastDigit;
    return sumD;
}



