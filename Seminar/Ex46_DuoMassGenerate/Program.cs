// Задайте двумерный массив заполненный случайными целыми числами.

Console.Clear();

int[,] matrix = new int[4, 4];

// void FillMatrix(int[,] matr, int minValue, int maxValue)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

// }
// FillMatrix(matrix, 1, 10);
// PrintMatrix(matrix);

// 48 Задача. Заполнить массив индекс + 1
void FillMatrixByIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i+j;
        }
    }
}
FillMatrixByIndex(matrix);



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