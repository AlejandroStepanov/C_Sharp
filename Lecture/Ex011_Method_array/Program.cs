//int[] array = {2, 5, 4, 8, 9, 0, 46};
//int n = array.Length;
//int find = 8;
//int index = 0;

//while (index<n)
//{
//    if(array[index] == find)
//   {
//        Console.WriteLine(index);
//        break;
//    }
//    index++;
//}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
        position = index;
        break;
        }
        index++;
    }
    return position;
}

int[] array = new int[20];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 5);
Console.WriteLine(pos);