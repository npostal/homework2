// Напишите программу, которая 
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int num = number.Length;

if (num == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндромом");
    }
}
else
    Console.WriteLine("Нужно ввести пятизначное число");