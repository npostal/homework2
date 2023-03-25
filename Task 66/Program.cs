// Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numM = Input("Задайте значение M: ");
int numN = Input("Задайте значение N: ");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void SumNumbers(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
        return;
    }
    sum = sum + (numM++);
    SumNumbers(numM, numN, sum);
}

SumNumbers(numM, numN, 0);