﻿// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int quantityNumber = QuantityNumber(number);
// Console.WriteLine($"Количество цифр в числе {number} -> {QuantityNumber}");

// int QuantityNumber(int num)
// {
//     int i = 0;
//     while (num > 0) 
//     {
//         num = num / 10;
//         i++;
//     }
//     return i;
// }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantityNumber = QuantityNumber(number);
Console.WriteLine($"Количество цифр в числе {number} -> {quantityNumber} ");

int QuantityNumber(int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

