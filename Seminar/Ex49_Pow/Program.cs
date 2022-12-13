//49 Задача. // **Задача 49:** Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

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
FillMatrix(matrix, 1, 10);

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

void SwrtChetIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] *= matr[i, j];
            }
        }
    }
}
SwrtChetIndex(matrix);

PrintMatrix(matrix);


