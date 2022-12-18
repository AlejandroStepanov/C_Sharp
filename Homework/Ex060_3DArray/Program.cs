// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] array = new int[2, 4, 4];

int[] mass = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

void Rand(int[] array)
{
    Random r = new Random();
    int j = 0;
    while (j < array.Length)
    {
        int p = r.Next(10, 100);
        bool b = true;

        for (int i = 0; i < j; i++)
            if (p == array[i])
            {
                b = false;
                break;
            }
        if (b)
        {
            array[j] = p;
            j++;
        }
    }  
}

Rand(mass);

void Fill(int[,,] arr)
{
    int l = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int k = 0; k < arr.GetLength(2); k++, l++)
            {

                arr[i, j, k] = mass[l];

            }
        }
    }
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");//
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Fill(array);
PrintMatrix(array);