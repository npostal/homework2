// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нужно ввести трёхзначное число");
}