// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = Input("Введите положительное натуральное число m: ");
int n = Input("Введите положительное натуральное число n: ");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

AckermanFunctions(m, n);

void AckermanFunctions(int m, int n)
{
    Console.Write(Ackerman(m, n));
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return (Ackerman(m - 1, Ackerman(m, n - 1)));
    }
}