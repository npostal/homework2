//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;
//         arr[i] = Math.Round(num, 1);
//     }
//     return arr;
// }

// void PrintArrayDouble(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }



Console.WriteLine("Задайте размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);


