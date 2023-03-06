﻿// Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number); //7
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num) //7
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + 1;
    }
    return sum; //28
}