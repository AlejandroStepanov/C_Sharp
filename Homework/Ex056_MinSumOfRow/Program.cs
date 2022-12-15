// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();
int[,] matrix = new int[7, 7];

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

int[,] SumRows(int[,] matr) 
{
    int[,] matrResult = new int[matr.GetLength(0), 1];

    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        matrResult[i, 0] = sum;
    }
    return matrResult;
}

// int[] GetRowArray(int[,] inArray) // Можно сделать так и найти индекс
// {
//     int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
//     int index=0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[i * inArray.GetLength(1) + j] = inArray[i,j];
//             index++;
//         }
//     }
//     return result;
// }

int[,] array = SumRows(matrix);

PrintMatrix(array);

void MinRow(int[,] matr)
{
    int i = 0;
    int min = matr[i, 0];
    for (int j = 1; j < matr.GetLength(0); j++)
    {
        if (matr[j, 0] < min)
        {
            min = matr[j, 0];
            i=j;
        }
    }
    // Console.WriteLine(min);
    Console.WriteLine($"Строка {i+1} имеет наименьшую сумму элементов");

}

MinRow(array);