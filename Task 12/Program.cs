// Напишите программу, которая будет принимать 
// 1. на вход два числа и 
// 2. выводить, является ли первое число
// кратным второму. 
// 3. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine($" {number1} и {number2} -> кратно");
}
else 
{

    Console.WriteLine($"{number1} и {number2} не кратно остаток -> {result}");
}