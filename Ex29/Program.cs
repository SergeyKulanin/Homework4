// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите минимальное число массива: ");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число массива: ");
int Max = Convert.ToInt32(Console.ReadLine());

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(Min, Max);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Console.Write($"[{String.Join("; ", col)}]"); 
}

int[] array = new int[8];
Console.WriteLine();
FillArray(array);
PrintArray(array);