// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
int[,] matrix = new int[4,4];
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
FillMatrix(matrix, 1, 9);

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
}
PrintMatrix(matrix);

int DiagonalSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            if (i==j)
            {
                sum = sum + matr[i,j];
            }
        }
    }
    return sum;
}

int x = DiagonalSum(matrix);
Console.WriteLine(x);
