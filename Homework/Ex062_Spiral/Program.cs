// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;
Clear();
int[,] array = new int[4, 4];


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


void Spiral(int[,] matr)
{
    int n = 4;
    int pos = 10;
    int count = n;
    int value = -n;
    int sum = -1;


    do
    {
        value = -1 * value / n;//(-1 * -4) /4 = 0
        for (int i = 0; i < count; i++)
        {
            sum += value;//-1+0
            matr[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            matr[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

}

Spiral(array);


PrintMatrix(array);

