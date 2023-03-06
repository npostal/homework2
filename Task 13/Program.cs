// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numDigit = number;
if (numDigit > 3)
{
    if (numDigit > 3)
    {
        number = number / 1;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра введённого числа -> {number}");
}
else
{
    if (numDigit <= 2)
    {
        Console.WriteLine("третьей цифры нет");
    }
}
