////Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, 
//если это невозможно, программа должна вывести сообщение для пользователя.

// using System;
// using static System.Console;

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

void RowsChangeColums(int[,] matr)
{
    if(matr.GetLength(0) != matr.GetLength(1))
    {
        Console.WriteLine("Нельзя поменять");
        return;
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = i; j < matr.GetLength(1); j++)
        {
            int temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
    }
}

RowsChangeColums(matrix);
PrintMatrix(matrix);