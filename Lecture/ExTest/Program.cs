

void FiiArr(int[] randomArr)
{
    int size = randomArr.Length;
    int index = 0;
    while(index<size)
    {
        randomArr[index] = new Random().Next(5, 28);
        index++;
    }
}

void PtintArr(int[] newcol)
{
    int count = newcol.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.Write($"{newcol[pos]} ");
        pos++;
    }

}


void FillPrint(int[] arr1)
{
    int size = arr1.Length;
    int index = 0;
    while (index<size)
    {
        arr1[index] = new Random().Next(1, 16);
        Console.Write($"{arr1[index]} ");
        index++;
    }

}

int[] array = new int[7];

FillPrint(array);
