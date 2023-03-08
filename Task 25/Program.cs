// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("введите число A");
int digitA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int digitB = Convert.ToInt32(Console.ReadLine());
int num = digitA;

for (int i = 1; i < digitB; i++)
{
    num = num * digitA;
}
Console.WriteLine($"{digitA}, {digitB} -> {num}");