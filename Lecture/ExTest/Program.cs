

// void FiiArr(int[] randomArr)
// {
//     int size = randomArr.Length;
//     int index = 0;
//     while(index<size)
//     {
//         randomArr[index] = new Random().Next(5, 28);
//         index++;
//     }
// }

// void PtintArr(int[] newcol)
// {
//     int count = newcol.Length;
//     int pos = 0;
//     while (pos<count)
//     {
//         Console.Write($"{newcol[pos]} ");
//         pos++;
//     }

// }


// void FillPrint(int[] arr1)
// {
//     int size = arr1.Length;
//     int index = 0;
//     while (index<size)
//     {
//         arr1[index] = new Random().Next(1, 16);
//         Console.Write($"{arr1[index]} ");
//         index++;
//     }

// }

// int[] array = new int[7];

// FillPrint(array);

////////////////////////////////

int[] array = { 1, 1, 1, 1, 1 };

string Pol(int[] array)
{
    string result = string.Empty;
    int lastInx = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++, lastInx--)
    {
         if (array[i] != array[lastInx])
        {
            result = result + "No";
            return result;
        }
    }
    result = result + "Yes";
    return result;

}


string YorN = Pol(array);
Console.WriteLine(YorN);


// string Pol(int[] array);
// for (int j = 0; j < array.Length / 2; j++, count--)
// {
//     string result = String.Empty;
//     if (array[j] != array[count - 1])
//     {
//         result = "Число не палиндром";
//         return result;
//     }

//         Console.WriteLine($"Число {a} палиндром");
//         break;
// }
