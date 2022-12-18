Console.Clear();

int n = 20;
int[] array = new int[n];

// for (int j = 0; j < n; j++)
// {
//     array[j] = new Random().Next(10, 100);
// }

// for (int j = 0; j < n; j++)
// {
//     Console.Write($"{array[j]} ");
// }
// Console.WriteLine();



void Rand(int[] array)
{

    Random r = new Random();
    int j = 0;
    while (j < array.Length)
    {
        int p = r.Next(10, 100); // новое число
        bool b = true;
        // Проверка, имеется ли уже такое число в массиве
        for (int i = 0; i < j; i++)
            if (p == array[i])
            {
                b = false;
                break; // досрочный выход из цикла for, если такое число уже имеется в массиве
            }
        if (b)
        {
            array[j] = p;
            j++;
        }
    }  // конец цикла while
       // return Nq;  // возврат Nq - фактическая длина массива
}


Rand(array);

for (int j = 0; j < n; j++)
{
    Console.Write($"{array[j]} ");
}
