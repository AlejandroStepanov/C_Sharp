// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatr(int[,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)//перебор строк
    {
        for (int i = 0; i < matr.GetLength(1); i++)//Перебор элементов
        {
            for (int j = i + 1; j < matr.GetLength(1); j++)//Перебор следующего значения
            {
                if (matr[k, i] < matr[k, j])//Сравнение, если надо обмен.
                {
                    int temp = matr[k, i];
                    matr[k, i] = matr[k, j];
                    matr[k, j] = temp;
                }
            }
        }
    }
}

SortMatr(matrix);
PrintMatrix(matrix);



