// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] array = new int[8];
void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int GetEvenElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 != 1) sum = sum + 1;
    }
    return sum;
}

FillArray();
PrintArray(array);
Console.WriteLine($"Sum Odd Elements =  {GetEvenElements(array)}");