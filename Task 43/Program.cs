//  Напишите программу, 
//  которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double meaningb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double meaningk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double meaningb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double meaningk2 = Convert.ToInt32(Console.ReadLine());

double x = (-meaningb2 + meaningb1)/(-meaningk1 + meaningk2);
double y = meaningk2 * x + meaningb2;

Console.Write($"b1 = {meaningb1}, k1 = {meaningk1}, b2 = {meaningb2}, k2 = {meaningk2} -> ({x}; {y})");