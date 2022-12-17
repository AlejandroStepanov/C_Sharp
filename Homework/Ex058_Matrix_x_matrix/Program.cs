// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;
Clear();
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

int[,] matrixA = new int[3, 4];
int[,] matrixB = new int[4, 5];

FillMatrix(matrixA, 1, 4);
FillMatrix(matrixB, 1, 4);

PrintMatrix(matrixA);
PrintMatrix(matrixB);


int[,] MatrixMultiplication(int[,] mart1, int[,] matr2)
{
    if (mart1.GetLength(1) != matr2.GetLength(0)) WriteLine("Count colums A != rows B");
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i<mart1.GetLength(0); i++)
    {
      for (int  j= 0; j<matr2.GetLength(1); j++)
      {
        matrixC[i, j] = 0;
        for(int k = 0; k<mart1.GetLength(1); k++)
        {
            matrixC [i,j] += mart1[i,k]*matr2[k,j];
        }
      }  
    }

    return matrixC;
}


int[,] matrixC = MatrixMultiplication(matrixA,matrixB);
PrintMatrix(matrixC);

