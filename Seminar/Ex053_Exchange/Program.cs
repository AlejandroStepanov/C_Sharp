// Задайте двуменый массив. Поменять местами первую и последнюю строки.


Console.Clear();
int[,] matrix = new int[4, 4];
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

void ChangeRows(int[,] matr)
{
    int rowCount = matr.GetLength(0) - 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[rowCount, i];
        matr[rowCount, i] = temp;
    }
}

ChangeRows(matrix);
PrintMatrix(matrix);
