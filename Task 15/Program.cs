// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели, что бы узнать является ли этот день выходным");
string day = Console.ReadLine();
switch (day)
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
        {
            Console.WriteLine("Нет");
            break;
        }
    case "6":
    case "7":
        {
            Console.WriteLine("Да");
            break;
        }
    default:
        {
            Console.WriteLine("Неверный ввод");
            break;
        }
}