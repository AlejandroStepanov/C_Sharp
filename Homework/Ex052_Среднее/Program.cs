// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] matrix = new int[7, 4];

void FillMatrix(int[,] matr, int minValue, int maxValue)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

}

FillMatrix(matrix, 1, 3);

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintMatrix(matrix);

void AverageSum(int[,] matr)
{
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;//обнуляем для след. итерации
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"Avrg colums {j} = {sum / matr.GetLength(0):f} ");
    }

}

AverageSum(matrix);