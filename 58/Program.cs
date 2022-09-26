//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int height = EnterInt("введи количество строк в массиве: ");
int width = EnterInt("введи количество столбцов в массиве: ");
int min = EnterInt("введи минимальное значение элемена массива: ");
int max = EnterInt("введи максимальное значение элемена массива: ");

int[,] firstNumbers = new int[height, width];
int[,] secondNumbers = new int[height, width];
Fill2DArray(firstNumbers, height, width);
Fill2DArray(secondNumbers, height, width);
Print2DArray(firstNumbers, height, width);
Console.WriteLine();
Print2DArray(secondNumbers, height, width);
Console.WriteLine("Произведение матриц:");
MultiplyArrays(firstNumbers, secondNumbers);
PrintNewArray(firstNumbers, secondNumbers);

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

int[,] MultiplyArrays(int[,] firstNumbers, int[,] secondNumbers)
{
    int[,] numbers = new int[firstNumbers.GetLength(0), secondNumbers.GetLength(1)];

    for (int i = 0; i < firstNumbers.GetLength(0); ++i)
    {
        for (int j = 0; j < secondNumbers.GetLength(0); ++j)
        {
            for (int k = 0; k < secondNumbers.GetLength(1); ++k)
            {
                numbers[i, k] += firstNumbers[i, j] * secondNumbers[j, k];
            }
        }
    }
    return numbers;
}

void PrintNewArray(int[,] firstNumbers, int[,] secondNumbers)
{
    int[,] numbers = MultiplyArrays(firstNumbers, secondNumbers);

    for (int i = 0; i < firstNumbers.GetLength(0); ++i)
    {
        for (int j = 0; j < secondNumbers.GetLength(1); ++j)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}