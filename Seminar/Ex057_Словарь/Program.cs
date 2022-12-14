// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных

using System;
using static System.Console;

Clear();
int[,] matrix = new int[5, 5];

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
    Console.WriteLine();
}
PrintMatrix(matrix);
Console.WriteLine();