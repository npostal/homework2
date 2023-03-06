// Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// array[i] = 1234;
// int arrNum = array[i];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 
// }

int[] array = new int[8];

FillArray(array);
WriteArray(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}
void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
}