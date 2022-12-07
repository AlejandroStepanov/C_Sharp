// В массиве нйти минимальное и поменять с первый, мин со вторым...
int[] arr = {3, 5, 2, 7, 8, 4, 1 , 1, 2, 6};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i =0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void Selectionsort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
           if(array[j]<array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;

    }
}
PrintArray(arr);
Selectionsort(arr);
PrintArray(arr);