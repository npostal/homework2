// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string cord = Cord(number);

Console.WriteLine(cord);

string Cord(int num)
{
    if (num == 1) return "Диапозон возможных координат -> (x > 0, y > 0)";
    if (num == 2) return "Диапозон возможных координат -> (x < 0, y > 0)";
    if (num == 3) return "Диапозон возможных координат -> (x < 0, y < 0)";
    if (num == 4) return "Диапозон возможных координат -> (x > 0, y < 0)";
    return "Введен некорректный номер четверти";
}
