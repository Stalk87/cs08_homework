//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int height = EnterInt("введи количество строк в массиве: ");
int width = EnterInt("введи количество столбцов в массиве: ");
int min = EnterInt("введи минимальное значение элемена массива: ");
int max = EnterInt("введи максимальное значение элемена массива: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
FindSmallestString(CreateNewArray(numbers, height, width));

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[] CreateNewArray(int[,] numbers, int height, int width)
{
    int[] str = new int[height];
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            str[i] += numbers[i, j];
        }
    }
    return str;
}

void FindSmallestString(int[] numbers)
{
    int minRow = numbers[0];
    int numberMinRow = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minRow)
        {
            minRow = numbers[i];
            numberMinRow = i;
        }
    }
    Console.WriteLine($"сумма элементов {numberMinRow + 1} строки меньше других и равна = {minRow}");
}