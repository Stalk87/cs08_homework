//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("введи длину и ширину массива:");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[n, n];

int count = 1;
int i = 0;
int j = 0;

while (count <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= array.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > array.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}