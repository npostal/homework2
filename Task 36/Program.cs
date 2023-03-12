// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);

void FillArray(int[] arraySize)
{
    Random rnd = new Random();
    for (int i = 0; i < arraySize.Length; i++)
    {
        arraySize[i] = rnd.Next(-10, 10);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
}

PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i += 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);